
using NUnit.Framework;

namespace Nancy.Simple
{
    [TestFixture]
	public class GameStateTests 
	{
		[Test]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 2)]
        [TestCase(10, ExpectedResult = 20)]
		public int BigBlind_is_twice_as_SmallBlind(int smallBlind)
		{
		    var sut = CreateGameState();
		    sut.SmallBlind = smallBlind;

		    return sut.BigBlind;
		}

        private GameState CreateGameState()
        {
            return new GameState();
        }
	}
}