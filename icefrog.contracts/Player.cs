using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Icefrog
{
    public class Player
    {
        public JToken PlayerToken { get; set; }

        public Player(JToken playerToken)
        {
            this.PlayerToken = playerToken;
            try
            {
                this.Bet = playerToken.Value<int>("bet");
                this.HoleCards = new List<Card>();
                foreach (var cardToken in playerToken.SelectToken("hole_cards"))
                {
                    this.HoleCards.Add(new Card(cardToken));
                }
                this.Id = playerToken.Value<int>("id");
                this.Name = playerToken.Value<string>("name");
                this.Stack = playerToken.Value<int>("stack");
                this.Status = playerToken.Value<string>("status");
                this.Version = playerToken.Value<string>("version");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        IEnumerable<Card> _holeCards = new List<Card>();

        public int Bet { get; set; }

        public IList<Card> HoleCards { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Stack { get; set; }

        public string Status { get; set; }

        public string Version { get; set; }
    }
}