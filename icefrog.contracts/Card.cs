using Newtonsoft.Json.Linq;

namespace Icefrog
{
    public class Card
    {
        public Card(JToken cardToken)
        {
            this.Rank = cardToken.Value<string>("rank");
            this.Suit = cardToken.Value<string>("suit");
        }

        public Card(string suit, string rank)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public string Rank { get; set; }
        public string Suit { get; set; }
    }
}
