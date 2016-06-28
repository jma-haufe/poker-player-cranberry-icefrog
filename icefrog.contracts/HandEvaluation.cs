using System.Collections.Generic;

namespace Icefrog
{
    public class HandEvaluation
    {
        public IEnumerable<Card> HoleCards { get; set; }
        public IEnumerable<Card> CommunityCards { get; set; }

        public bool IsOnePair
        {
            get
            {
                var cards = new List<Card>();
                cards.AddRange(HoleCards);
                cards.AddRange(CommunityCards);

                for (int i = 0; i < cards.Count; i++)
                {
                    var card = cards[0];
                    return false;
                }


                return false;
            }
        }
    }
}