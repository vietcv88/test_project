﻿#region using directives

using System.Linq;
using System.Threading.Tasks;
using PokemonGo.RocketBot.Logic.Event;
using PokemonGo.RocketBot.Logic.PoGoUtils;
using PokemonGo.RocketBot.Logic.State;
using PokemonGo.RocketBot.Logic.Utils;

#endregion

namespace PokemonGo.RocketBot.Logic.Tasks
{
    public class TransferSpecificPokemonTask
    {
        public static async Task Execute(ISession session, ulong pokemonId)
        {
            var all = await session.Inventory.GetPokemons();
            var pokemons = all.OrderBy(x => x.Cp).ThenBy(n => n.StaminaMax);
            var pokemon = pokemons.FirstOrDefault(p => p.Id == pokemonId);

            if (pokemon == null) return;

            var pokemonSettings = await session.Inventory.GetPokemonSettings();
            var pokemonFamilies = await session.Inventory.GetPokemonFamilies();

            await session.Client.Inventory.TransferPokemon(pokemonId);
            await session.Inventory.DeletePokemonFromInvById(pokemonId);

            var bestPokemonOfType = (session.LogicSettings.PrioritizeIvOverCp
                ? await session.Inventory.GetHighestPokemonOfTypeByIv(pokemon)
                : await session.Inventory.GetHighestPokemonOfTypeByCp(pokemon)) ?? pokemon;

            var setting = pokemonSettings.Single(q => q.PokemonId == pokemon.PokemonId);
            var family = pokemonFamilies.First(q => q.FamilyId == setting.FamilyId);

            family.Candy_++;

            // Broadcast event as everyone would benefit
            session.EventDispatcher.Send(new TransferPokemonEvent
            {
                Id = pokemon.PokemonId,
                Perfection = PokemonInfo.CalculatePokemonPerfection(pokemon),
                Cp = pokemon.Cp,
                BestCp = bestPokemonOfType.Cp,
                BestPerfection = PokemonInfo.CalculatePokemonPerfection(bestPokemonOfType),
                FamilyCandies = family.Candy_
            });

            DelayingUtils.Delay(session.LogicSettings.DelayBetweenPlayerActions, 0);
        }
    }
}