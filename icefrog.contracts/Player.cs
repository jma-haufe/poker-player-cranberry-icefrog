using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Icefrog
{
    public class Player
    {
        public Player(JToken playerObject)
        {
            try
            {
                this.Bet = playerObject.Value<int>("bet");
                this.HoleCards = new List<Card>();
                foreach (var cardToken in playerObject.Values())
                {
                    this.HoleCards.Add(new Card(cardToken));
                }
                this.Id = playerObject.Value<int>("id");
                this.Name = playerObject.Value<string>("name");
                this.Stack = playerObject.Value<int>("stack");
                this.Status = playerObject.Value<string>("status");
                this.Version = playerObject.Value<string>("version");
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