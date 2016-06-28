using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
    public class GameState
    {
        public GameState(JObject gameState)
        {
            SmallBlind = gameState.Value<int>("small_blind");
            CurrentBuyIn = gameState.Value<int>("current_buy_in");
        }

        public int CurrentBuyIn { get; set; }

        public int SmallBlind { get; set; }
    }
}
