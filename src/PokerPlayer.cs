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

                bool isPreFlop = hand.AllCards.Count == 2;
                bool isFlop = hand.AllCards.Count > 2;

                if (isPreFlop)
                {
                    bet = gs.CurrentBuyIn;

                    if (hand.IsHighCard)
                    {
                        bet += gs.BigBlind;
                    }
                    else if (hand.IsOnePair)
                    {
                        bet += gs.BigBlind + gs.SmallBlind;
                    }
                    else if (hand.IsHighCard && hand.IsOnePair)
                    {
                        bet += gs.BigBlind*2;
                    }
                }
                if (isFlop)
                {
                    bet = gs.CurrentBuyIn;

                    if (hand.IsFourOfAKind)
                    {
                        bet *= 4;
                    }
                    else if (hand.IsThreeOfAKind)
                    {
                        bet *= 3;
                    }
                    else if (hand.IsOnePair)
                    {
                        bet *= 2;
                    }
                    else if (hand.IsHighCard)
                    {
                        // do nothing
                    }
                    else
                    {
                        bet = 0;
                    }
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

