using System;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Default C# folding player";

		public static int BetRequest(JObject gameState)
		{
            int bet = 0;
            var smallBlind = gameState.Value<int>("small_blind");

            bet = smallBlind * 2;

            return bet;
		}
        
        public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}
	}
}

