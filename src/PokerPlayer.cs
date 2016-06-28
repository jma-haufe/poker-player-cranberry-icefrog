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
            int bet = -1;
            try
            {
                var gs = new GameState(gameState);

                bet = gs.CurrentBuyIn + gs.BigBlind;

                Console.WriteLine("CurrentBuyIn: " + gs.CurrentBuyIn);
                Console.WriteLine("BigBlind: " + gs.BigBlind);
                Console.WriteLine("bet: " + bet);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (bet < 0) bet = 10000;
            return bet;
		}
        
        public static void ShowDown(JObject gameState)
		{
		}
	}
}

