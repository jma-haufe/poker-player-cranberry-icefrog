using Newtonsoft.Json.Linq;

namespace Icefrog
{
    public class GameState
    {
        public GameState()
        {
        }

        public GameState(JObject gameState)
        {
            SmallBlind = gameState.Value<int>("small_blind");
            CurrentBuyIn = gameState.Value<int>("current_buy_in");
        }

        public int CurrentBuyIn { get; set; }

        public int SmallBlind { get; set; }

        public int BigBlind
        {
            get { return this.SmallBlind*2; }
        }
    }
}
