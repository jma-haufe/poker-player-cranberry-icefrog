using System;
using Icefrog;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Cranberry Icefrogs Pokerbot 1";

		public static int BetRequest(JObject gameState)
		{
            var gs = new GameState(gameState);

            int bet = gs.CurrentBuyIn + gs.SmallBlind * 2;
            

            return bet;
		}
        
        public static void ShowDown(JObject gameState)
		{
		}
	}
}

