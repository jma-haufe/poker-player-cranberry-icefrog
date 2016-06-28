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

            int bet = gs.CurrentBuyIn + gs.BigBlind;

            Console.WriteLine("CurrentBuyIn: " + gs.CurrentBuyIn);
            Console.WriteLine("BigBlind: " + gs.BigBlind);
            Console.WriteLine("bet: " + bet);

            if (bet < 0) bet = 10000;
            return bet;
		}
        
        public static void ShowDown(JObject gameState)
		{
		}
	}
}

