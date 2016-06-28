using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Icefrog
{
    public class HandEvaluation
    {
        public List<Card> AllCards
        {
            get { return JoinCards(HoleCards, CommunityCards); }
        }

        public IEnumerable<Card> CommunityCards { get; set; }
        public IEnumerable<Card> HoleCards { get; set; }

        public bool IsHighCard
        {
            get
            {
                var cards = JoinCards(HoleCards, CommunityCards);
                return cards.Any(card => card.Rank.ToUpper() == "K" || card.Rank.ToUpper() == "A");
            }
        }
        
public bool IsOnePair
        {
            get
            {
                var cards = JoinCards(HoleCards, CommunityCards);
                return HasSameOfAKind(cards, 2);
            }
        }

        public bool IsThreeOfAKind
        {
            get
            {
                var cards = JoinCards(HoleCards, CommunityCards);
                return HasSameOfAKind(cards, 3);
            }
        }

        public bool IsFourOfAKind
        {
            get
            {
                var cards = AllCards;
                return HasSameOfAKind(cards, 4);
            }
        }

        private static bool HasSameOfAKind(List<Card> cards, int sameKind)
        {
            int sameRank = 0;
            foreach (var leftCard in cards)
            {
                foreach (var rightCard in cards)
                {
                    if (rightCard == leftCard)
                    {
                        continue;
                    }

                    if (rightCard.Rank == leftCard.Rank)
                    {
                        sameRank++;
                    }

                    if (sameRank == sameKind)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static List<Card> JoinCards(params IEnumerable<Card>[] cardCollections)
        {
            var joinedCards = new List<Card>();
            foreach (var cardCollection in cardCollections)
            {
                joinedCards.AddRange(cardCollection);
            }
            return joinedCards;
        }
    }
}