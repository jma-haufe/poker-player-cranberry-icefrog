using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Icefrog
{
    public class GameState
    {
        public GameState()
        {
            this.Players = new List<Player>();
            this.CommunityCards = new List<Card>();
        }

        public GameState(JObject gameState) : this()
        {
            SmallBlind = gameState.Value<int>("small_blind");
            CurrentBuyIn = gameState.Value<int>("current_buy_in");

            try
            {
                foreach (var playerObject in gameState.GetValue("players"))
                {
                    this.Players.Add(new Player(playerObject));
                }

                foreach (var cardObject in gameState.Values("community_cards"))
                {
                    this.CommunityCards.Add(new Card(cardObject));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public int CurrentBuyIn { get; set; }

        public int SmallBlind { get; set; }

        public int BigBlind
        {
            get { return this.SmallBlind * 2; }
        }

        public IList<Player> Players { get; set; }

        public IList<Card> CommunityCards { get; set; }

    }
}
