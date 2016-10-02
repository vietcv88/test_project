﻿#region using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GeoCoordinatePortable;
using PokemonGo.RocketAPI.Extensions;
using PokemonGo.RocketBot.Logic.Common;
using PokemonGo.RocketBot.Logic.Event;
using PokemonGo.RocketBot.Logic.Logging;
using PokemonGo.RocketBot.Logic.State;
using PokemonGo.RocketBot.Logic.Utils;
using POGOProtos.Map.Fort;
using POGOProtos.Networking.Responses;

#endregion

namespace PokemonGo.RocketBot.Logic.Tasks
{
    public static class FarmPokestopsTask
    {
        public delegate void LootPokestopDelegate(FortData pokestop);

        public static int TimesZeroXPawarded;
        private static int _storeRi;

        public static async Task Execute(ISession session, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var distanceFromStart = LocationUtils.CalculateDistanceInMeters(
                session.Settings.DefaultLatitude, session.Settings.DefaultLongitude,
                session.Client.CurrentLatitude, session.Client.CurrentLongitude);

            // Edge case for when the client somehow ends up outside the defined radius
            if (session.LogicSettings.MaxTravelDistanceInMeters != 0 &&
                distanceFromStart > session.LogicSettings.MaxTravelDistanceInMeters)
            {
                Logger.Write(
                    session.Translation.GetTranslation(TranslationString.FarmPokestopsOutsideRadius, distanceFromStart),
                    LogLevel.Warning);

                await session.Navigation.Move(new GeoCoordinate(
                    session.Settings.DefaultLatitude,
                    session.Settings.DefaultLongitude,
                    LocationUtils.getElevation(session.Settings.DefaultLatitude,
                        session.Settings.DefaultLongitude)),
                    null,
                    session,
                    cancellationToken);
            }

            var pokestopList = await GetPokeStops(session);

            //get optimized route
            var pokeStops = RouteOptimizeUtil.Optimize(pokestopList.ToArray(), session.Client.CurrentLatitude,
                session.Client.CurrentLongitude);

            var stopsHit = 0;
            var rc = new Random(); //initialize pokestop random cleanup counter first time
            _storeRi = rc.Next(8, 15);
            var eggWalker = new EggWalker(1000, session);

            if (pokestopList.Count <= 0)
            {
                session.EventDispatcher.Send(new WarnEvent
                {
                    Message = session.Translation.GetTranslation(TranslationString.FarmPokestopsNoUsableFound)
                });
            }

            session.EventDispatcher.Send(new PokeStopListEvent {Forts = pokestopList});

            foreach (var pokeStop in pokeStops)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var distance = LocationUtils.CalculateDistanceInMeters(session.Client.CurrentLatitude,
                    session.Client.CurrentLongitude, pokeStop.Latitude, pokeStop.Longitude);
                var fortInfo = await session.Client.Fort.GetFort(pokeStop.Id, pokeStop.Latitude, pokeStop.Longitude);

                session.EventDispatcher.Send(new FortTargetEvent {Name = fortInfo.Name, Distance = distance});

                var targetLocation = new GeoCoordinate(pokeStop.Latitude, pokeStop.Longitude,
                    LocationUtils.getElevation(pokeStop.Latitude, pokeStop.Longitude));
                await session.Navigation.Move(targetLocation,
                    async () =>
                    {
                        // Catch normal map Pokemon
                        await CatchNearbyPokemonsTask.Execute(session, cancellationToken);
                        //Catch Incense Pokemon
                        await CatchIncensePokemonsTask.Execute(session, cancellationToken);
                        return true;
                    },
                    session,
                    cancellationToken);

                //Check if pokestop is in range, if not, move to pokestop without google routing
                if (
                    LocationUtils.CalculateDistanceInMeters(targetLocation,
                        new GeoCoordinate(session.Client.CurrentLatitude, session.Client.CurrentLongitude)) >= 30)
                    await session.Navigation.Move(targetLocation, null, session, cancellationToken, true);

                //Catch Lure Pokemon
                if (pokeStop.LureInfo != null)
                {
                    await CatchLurePokemonsTask.Execute(session, pokeStop, cancellationToken);
                }

                FortSearchResponse fortSearch;
                var timesZeroXPawarded = 0;
                var fortTry = 0; //Current check
                const int retryNumber = 50; //How many times it needs to check to clear softban
                const int zeroCheck = 5; //How many times it checks fort before it thinks it's softban
                do
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    fortSearch =
                        await session.Client.Fort.SearchFort(pokeStop.Id, pokeStop.Latitude, pokeStop.Longitude);
                    if (fortSearch.ExperienceAwarded > 0 && timesZeroXPawarded > 0) timesZeroXPawarded = 0;
                    if (fortSearch.ExperienceAwarded == 0)
                    {
                        timesZeroXPawarded++;

                        if (timesZeroXPawarded > zeroCheck)
                        {
                            if ((int) fortSearch.CooldownCompleteTimestampMs != 0)
                            {
                                break;
                                // Check if successfully looted, if so program can continue as this was "false alarm".
                            }

                            fortTry += 1;

                            session.EventDispatcher.Send(new FortFailedEvent
                            {
                                Name = fortInfo.Name,
                                Try = fortTry,
                                Max = retryNumber - zeroCheck,
                                Looted = false
                            });

                            if (!session.LogicSettings.FastSoftBanBypass)
                            {
                                DelayingUtils.Delay(session.LogicSettings.DelayBetweenPlayerActions, 0);
                            }
                        }
                    }
                    else
                    {
                        if (fortTry != 0)
                        {
                            session.EventDispatcher.Send(new FortFailedEvent
                            {
                                Name = fortInfo.Name,
                                Try = fortTry + 1,
                                Max = retryNumber - zeroCheck,
                                Looted = true
                            });
                        }

                        session.EventDispatcher.Send(new FortUsedEvent
                        {
                            Id = pokeStop.Id,
                            Name = fortInfo.Name,
                            Exp = fortSearch.ExperienceAwarded,
                            Gems = fortSearch.GemsAwarded,
                            Items = StringUtils.GetSummedFriendlyNameOfItemAwardList(fortSearch.ItemsAwarded),
                            Latitude = pokeStop.Latitude,
                            Longitude = pokeStop.Longitude,
                            InventoryFull = fortSearch.Result == FortSearchResponse.Types.Result.InventoryFull
                        });

                        if (fortSearch.Result == FortSearchResponse.Types.Result.InventoryFull)
                            _storeRi = 1;

                        OnLootPokestopEvent(pokeStop);
                        break; //Continue with program as loot was succesfull.
                    }
                } while (fortTry < retryNumber - zeroCheck);
                //Stop trying if softban is cleaned earlier or if 40 times fort looting failed.

                await eggWalker.ApplyDistance(distance, cancellationToken);

                if (++stopsHit >= _storeRi)
                    //TODO: OR item/pokemon bag is full //check stopsHit against storeRI random without dividing.
                {
                    _storeRi = rc.Next(6, 12); //set new storeRI for new random value
                    stopsHit = 0;

                    await RecycleItemsTask.Execute(session, cancellationToken);

                    if (fortSearch.ItemsAwarded.Count > 0)
                        await session.Inventory.RefreshCachedInventory();

                    if (session.LogicSettings.EvolveAllPokemonWithEnoughCandy ||
                        session.LogicSettings.EvolveAllPokemonAboveIv ||
                        session.LogicSettings.UseLuckyEggsWhileEvolving ||
                        session.LogicSettings.KeepPokemonsThatCanEvolve)
                    {
                        await EvolvePokemonTask.Execute(session, cancellationToken);
                    }

                    if (session.LogicSettings.UseLuckyEggConstantly)
                        await UseLuckyEggConstantlyTask.Execute(session, cancellationToken);

                    if (session.LogicSettings.UseIncenseConstantly)
                        await UseIncenseConstantlyTask.Execute(session, cancellationToken);

                    if (session.LogicSettings.TransferDuplicatePokemon)
                        await TransferDuplicatePokemonTask.Execute(session, cancellationToken);

                    if (session.LogicSettings.TransferWeakPokemon)
                        await TransferWeakPokemonTask.Execute(session, cancellationToken);

                    if (session.LogicSettings.RenamePokemon)
                        await RenamePokemonTask.Execute(session, cancellationToken);

                    if (session.LogicSettings.AutoFavoritePokemon)
                        await FavoritePokemonTask.Execute(session, cancellationToken);

                    if (session.LogicSettings.AutomaticallyLevelUpPokemon)
                        await LevelUpPokemonTask.Execute(session, cancellationToken);

                    await GetPokeDexCount.Execute(session, cancellationToken);
                }

                if (session.LogicSettings.SnipeAtPokestops || session.LogicSettings.UseSnipeLocationServer)
                    await SnipePokemonTask.Execute(session, cancellationToken);
            }
        }

        private static async Task<List<FortData>> GetPokeStops(ISession session)
        {
            var mapObjects = await session.Client.Map.GetMapObjects();

            // Wasn't sure how to make this pretty. Edit as needed.
            var pokeStops = mapObjects.Item1.MapCells.SelectMany(i => i.Forts)
                .Where(
                    i =>
                        i.Type == FortType.Checkpoint &&
                        i.CooldownCompleteTimestampMs < DateTime.UtcNow.ToUnixTime() &&
                        ( // Make sure PokeStop is within max travel distance, unless it's set to 0.
                            LocationUtils.CalculateDistanceInMeters(
                                session.Settings.DefaultLatitude, session.Settings.DefaultLongitude,
                                i.Latitude, i.Longitude) < session.LogicSettings.MaxTravelDistanceInMeters ||
                            session.LogicSettings.MaxTravelDistanceInMeters == 0)
                );

            return pokeStops.ToList();
        }

        private static void OnLootPokestopEvent(FortData pokestop)
        {
            LootPokestopEvent?.Invoke(pokestop);
        }

        public static event LootPokestopDelegate LootPokestopEvent;
    }
}