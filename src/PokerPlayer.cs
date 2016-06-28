using System;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Cranberry Icefrogs Pokerbot";

        public static RainmanWrapper Rainman = new RainmanWrapper();

		public static int BetRequest(JObject gameState)
		{
            int bet = 0;
            var smallBlind = gameState.Value<int>("small_blind");
            var currentBuyIn = gameState.Value<int>("current_buy_in");
            bet = currentBuyIn + smallBlind * 2;

            var rainmainInfo = Rainman.GetInfo(gameState);

            
            return bet;
		}
        
        public static void ShowDown(JObject gameState)
		{
		}
	}
}

