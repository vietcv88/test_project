﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using PokemonGo.RocketBot.Logic.Common;
using PokemonGo.RocketBot.Logic.Event;
using PokemonGo.RocketBot.Logic.PoGoUtils;
using PokemonGo.RocketBot.Logic.State;
using POGOProtos.Data;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace PokemonGo.RocketBot.Logic.Service
{
    public class TelegramService
    {
        private readonly TelegramBotClient bot;
        private readonly ISession session;

        public TelegramService(string apiKey, ISession session)
        {
            bot = new TelegramBotClient(apiKey);
            this.session = session;

            var me = bot.GetMeAsync().Result;

            bot.OnMessage += OnTelegramMessageReceived;
            bot.StartReceiving();

            this.session.EventDispatcher.Send(new NoticeEvent {Message = "Using TelegramAPI with " + me.Username});
        }

        private async void OnTelegramMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            var message = messageEventArgs.Message;

            if (message == null || message.Type != MessageType.TextMessage)
                return;

            var answerTextmessage = "";

            if (session.Profile == null || session.Inventory == null)
            {
                return;
            }

            var messagetext = message.Text.Split(' ');

            switch (messagetext[0].ToLower())
            {
                case "/top":
                    var times = 10;
                    var sortby = "cp";
                    if (messagetext.Length == 3)
                    {
                        times = Convert.ToInt32(messagetext[2]);
                    }
                    if (messagetext.Length >= 2)
                    {
                        sortby = messagetext[1];
                    }

                    IEnumerable<PokemonData> topPokemons;
                    if (sortby.Equals("iv"))
                    {
                        topPokemons = await session.Inventory.GetHighestsPerfect(times);
                    }
                    else
                    {
                        topPokemons = await session.Inventory.GetHighestsCp(times);
                    }

                    foreach (var pokemon in topPokemons)
                    {
                        answerTextmessage += session.Translation.GetTranslation(TranslationString.ShowPokeTemplate,
                            pokemon.Cp, PokemonInfo.CalculatePokemonPerfection(pokemon).ToString("0.00"),
                            session.Translation.GetPokemonTranslation(pokemon.PokemonId));

                        if (answerTextmessage.Length > 3800)
                        {
                            SendMessage(message.Chat.Id, answerTextmessage);
                            answerTextmessage = "";
                        }
                    }
                    SendMessage(message.Chat.Id, answerTextmessage);
                    break;
                case "/all":
                    var myPokemons = await session.Inventory.GetPokemons();
                    var allMyPokemons = myPokemons.ToList();

                    var allPokemons = await session.Inventory.GetHighestsCp(allMyPokemons.Count);
                    ;
                    if (messagetext.Length == 2)
                    {
                        if (messagetext[1] == "iv")
                        {
                            allPokemons = await session.Inventory.GetHighestsPerfect(allMyPokemons.Count);
                        }
                    }

                    foreach (var pokemon in allPokemons)
                    {
                        answerTextmessage += session.Translation.GetTranslation(TranslationString.ShowPokeTemplate,
                            pokemon.Cp, PokemonInfo.CalculatePokemonPerfection(pokemon).ToString("0.00"),
                            session.Translation.GetPokemonTranslation(pokemon.PokemonId));

                        if (answerTextmessage.Length > 3800)
                        {
                            SendMessage(message.Chat.Id, answerTextmessage);
                            answerTextmessage = "";
                        }
                    }
                    SendMessage(message.Chat.Id, answerTextmessage);
                    break;
                case "/profile":
                    var stats = session.Inventory.GetPlayerStats().Result;
                    var stat = stats.FirstOrDefault();

                    var myPokemons2 = await session.Inventory.GetPokemons();
                    answerTextmessage += session.Translation.GetTranslation(
                        TranslationString.ProfileStatsTemplateString, stat.Level, session.Profile.PlayerData.Username,
                        stat.Experience, stat.NextLevelXp, stat.PokemonsCaptured, stat.PokemonDeployed,
                        stat.PokeStopVisits, stat.EggsHatched, stat.Evolutions, stat.UniquePokedexEntries, stat.KmWalked,
                        myPokemons2.ToList().Count, session.Profile.PlayerData.MaxPokemonStorage);
                    SendMessage(message.Chat.Id, answerTextmessage);
                    break;
                case "/pokedex":
                    var pokedex = session.Inventory.GetPokeDexItems().Result;
                    var pokedexSort = pokedex.OrderBy(x => x.InventoryItemData.PokedexEntry.PokemonId);

                    answerTextmessage += session.Translation.GetTranslation(TranslationString.PokedexCatchedTelegram);
                    foreach (var pokedexItem in pokedexSort)
                    {
                        answerTextmessage +=
                            session.Translation.GetTranslation(TranslationString.PokedexPokemonCatchedTelegram,
                                Convert.ToInt32(pokedexItem.InventoryItemData.PokedexEntry.PokemonId),
                                session.Translation.GetPokemonTranslation(
                                    pokedexItem.InventoryItemData.PokedexEntry.PokemonId),
                                pokedexItem.InventoryItemData.PokedexEntry.TimesCaptured,
                                pokedexItem.InventoryItemData.PokedexEntry.TimesEncountered);

                        if (answerTextmessage.Length > 3800)
                        {
                            SendMessage(message.Chat.Id, answerTextmessage);
                            answerTextmessage = "";
                        }
                    }

                    var pokemonsToCapture =
                        Enum.GetValues(typeof(PokemonId))
                            .Cast<PokemonId>()
                            .Except(pokedex.Select(x => x.InventoryItemData.PokedexEntry.PokemonId));

                    SendMessage(message.Chat.Id, answerTextmessage);
                    answerTextmessage = "";

                    answerTextmessage += session.Translation.GetTranslation(TranslationString.PokedexNeededTelegram);

                    foreach (var pokedexItem in pokemonsToCapture)
                    {
                        answerTextmessage +=
                            session.Translation.GetTranslation(TranslationString.PokedexPokemonNeededTelegram,
                                Convert.ToInt32(pokedexItem), session.Translation.GetPokemonTranslation(pokedexItem));

                        if (answerTextmessage.Length > 3800)
                        {
                            SendMessage(message.Chat.Id, answerTextmessage);
                            answerTextmessage = "";
                        }
                    }
                    SendMessage(message.Chat.Id, answerTextmessage);

                    break;
                case "/loc":
                    SendLocation(message.Chat.Id, session.Client.CurrentLatitude, session.Client.CurrentLongitude);
                    break;
                case "/items":
                    var inventory = session.Inventory;
                    answerTextmessage += session.Translation.GetTranslation(TranslationString.CurrentPokeballInv,
                        await inventory.GetItemAmountByType(ItemId.ItemPokeBall),
                        await inventory.GetItemAmountByType(ItemId.ItemGreatBall),
                        await inventory.GetItemAmountByType(ItemId.ItemUltraBall),
                        await inventory.GetItemAmountByType(ItemId.ItemMasterBall));
                    answerTextmessage += "\n";
                    answerTextmessage += session.Translation.GetTranslation(TranslationString.CurrentPotionInv,
                        await inventory.GetItemAmountByType(ItemId.ItemPotion),
                        await inventory.GetItemAmountByType(ItemId.ItemSuperPotion),
                        await inventory.GetItemAmountByType(ItemId.ItemHyperPotion),
                        await inventory.GetItemAmountByType(ItemId.ItemMaxPotion));
                    answerTextmessage += "\n";
                    answerTextmessage += session.Translation.GetTranslation(TranslationString.CurrentReviveInv,
                        await inventory.GetItemAmountByType(ItemId.ItemRevive),
                        await inventory.GetItemAmountByType(ItemId.ItemMaxRevive));
                    answerTextmessage += "\n";
                    answerTextmessage += session.Translation.GetTranslation(TranslationString.CurrentMiscItemInv,
                        await session.Inventory.GetItemAmountByType(ItemId.ItemRazzBerry) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemBlukBerry) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemNanabBerry) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemWeparBerry) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemPinapBerry),
                        await session.Inventory.GetItemAmountByType(ItemId.ItemIncenseOrdinary) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemIncenseSpicy) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemIncenseCool) +
                        await session.Inventory.GetItemAmountByType(ItemId.ItemIncenseFloral),
                        await session.Inventory.GetItemAmountByType(ItemId.ItemLuckyEgg),
                        await session.Inventory.GetItemAmountByType(ItemId.ItemTroyDisk));
                    SendMessage(message.Chat.Id, answerTextmessage);
                    break;
                case "/status":
                    SendMessage(message.Chat.Id, Console.Title);
                    break;
                case "/restart":
                    Process.Start(Assembly.GetEntryAssembly().Location);
                    SendMessage(message.Chat.Id, "Restarted Bot. Closing old Instance... BYE!");
                    Environment.Exit(-1);
                    break;
                default:
                    answerTextmessage += session.Translation.GetTranslation(TranslationString.HelpTemplate);
                    SendMessage(message.Chat.Id, answerTextmessage);
                    break;
            }
        }

        private async void SendLocation(long chatID, double currentLatitude, double currentLongitude)
        {
            await bot.SendLocationAsync(chatID, (float) currentLatitude, (float) currentLongitude);
        }

        private async void SendMessage(long chatID, string message)
        {
            await bot.SendTextMessageAsync(chatID, message, replyMarkup: new ReplyKeyboardHide());
        }
    }
}