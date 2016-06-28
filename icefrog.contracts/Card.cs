using Newtonsoft.Json.Linq;
using System;

namespace Icefrog
{
    public class Card
    {
        public Card(JToken cardToken)
        {
            try
            {
                this.Rank = cardToken.Value<string>("rank");
                this.Suit = cardToken.Value<string>("suit");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
