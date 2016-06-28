using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Icefrog
{
    public class Player
    {
        public Player(JToken playerObject)
        {
            this.Bet = playerObject.Value<int>("bet");
            this.HoleCards = new List<Card>();
            foreach (var cardToken in playerObject.Values())
            {

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