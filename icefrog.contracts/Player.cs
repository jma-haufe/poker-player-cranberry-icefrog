using System.Collections.Generic;

namespace Icefrog
{
    public class Player
    { 
        IEnumerable<Card> _holeCards = new List<Card>();

        public int Bet { get; set; }

        public IEnumerable<Card> HoleCards
        {
            get { return _holeCards; }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Stack { get; set; }

        public string Status { get; set; }

        public string Version { get; set; }
    }
}