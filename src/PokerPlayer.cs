using System;
using Icefrog;
using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
    public static class PokerPlayer
	{
		public static readonly string VERSION = "Cranberry Icefrogs start analyzing hand";

		public static int BetRequest(JObject gameState)
		{
            int bet = -1;
            try
            {
                var gs = new GameState(gameState);
                var hand = new HandEvaluation();

                bet = gs.CurrentBuyIn;

                if (hand.IsFourOfAKind)
                {
                    bet *= 2;
                }
                else if (hand.IsThreeOfAKind)
                {
                    bet *= 3;
                }
                else if (hand.IsOnePair)
                {
                    bet *= 2;
                }

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

