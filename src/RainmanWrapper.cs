using Newtonsoft.Json.Linq;
using System.Text;

namespace Nancy.Simple
{
    public class RainmanWrapper : NancyModule
    {
        public Nancy.Response GetInfo(JObject gameState)
        {
            var cards = "/";
            var players = gameState.Values("players");
            var self = players[1];
            var owncards = self.Values("hole_cards");
            var communityCards = gameState.Values("community_cards");
            var allCards = communityCards;

            Get[cards] = _ => {
                var contentBytes = Encoding.UTF8.GetBytes("OK");
                var response = new Response
                {
                    ContentType = "text/plain",
                    Contents = s => s.Write(contentBytes, 0, contentBytes.Length),
                    StatusCode = HttpStatusCode.OK
                };
                return response;
            };
            return null;
        }
    }
}
