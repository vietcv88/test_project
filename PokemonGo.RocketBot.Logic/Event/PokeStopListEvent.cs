﻿#region using directives

using System.Collections.Generic;
using POGOProtos.Map.Fort;

#endregion

namespace PokemonGo.RocketBot.Logic.Event
{
    public class PokeStopListEvent : IEvent
    {
        public List<FortData> Forts;
    }
}