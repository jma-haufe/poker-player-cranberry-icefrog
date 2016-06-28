using System.Collections.Generic;
using NUnit.Framework;

namespace Icefrog
{
    [TestFixture]
    public class HandEvaluationTests
    {
        private static IEnumerable<TestCaseData> OnePairTestData()
        {
            yield return new TestCaseData(
                new[]
                {
                    new Card("hearts", "K"),
                    new Card("spades", "K")
                },
                new[]
                {
                    new Card("hearts", "2"),
                    new Card("spades", "3"),
                    new Card("spades", "4")
                }
            );
        }

        [Test]
        [TestCaseSource("OnePairTestData")]
        public void IsOnePair_returns_true_when_two_cards_of_same_rank(Card[] holdCards, Card[] communityCards)
        {
            var sut = CreateHandEvaluation();
            sut.HoleCards = holdCards;
            sut.CommunityCards = communityCards;

            Assert.That(sut.IsOnePair, Is.True);
        }

        private HandEvaluation CreateHandEvaluation()
        {
            return new HandEvaluation();
        }
    }
}