using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Icefrog
{
    public class GameState
    {
        public GameState()
        {
            this.Players = new List<Player>();
        }

        public GameState(JObject gameState) : this()
        {
            SmallBlind = gameState.Value<int>("small_blind");
            CurrentBuyIn = gameState.Value<int>("current_buy_in");
            
            foreach(var playerObject  in gameState.Values("players"))
            {
                this.Players.Add(new Player(playerObject));
            }
        }

        public int CurrentBuyIn { get; set; }

        public int SmallBlind { get; set; }

        public int BigBlind
        {
            get { return this.SmallBlind * 2; }
        }

        public IList<Player> Players { get; private set; }

    }
}
