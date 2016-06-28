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

        public string Rank { get; set; }
        public string Suit { get; set; }
    }
}
