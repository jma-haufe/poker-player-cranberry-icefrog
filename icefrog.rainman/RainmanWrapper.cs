using Icefrog;
using Nancy;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System;
using System.Threading;

namespace Icefrog
{
    public class RainmanWrapper
    {
        private HttpWebRequest _lastRequest;
        private HttpWebResponse _lastResponse;

        public string GetRating(GameState gameState)
        {
            var cards = gameState.CommunityCards.Select(card => card.CardToken).ToList();
            var self = gameState.Players.First(p => p.Id == 1);
            cards.AddRange(self.HoleCards.Select(card => card.CardToken));

            string result = "";
            if (cards.Count >= 5)
            {
                var json = "cards=" + JsonConvert.SerializeObject(cards);
                _lastRequest = (HttpWebRequest) WebRequest.Create("http://rainman.leanpoker.org/rank");
                _lastRequest.Method = "POST";
                _lastRequest.ContentLength = json.Length;
                _lastRequest.ContentType = "application/json";
                using (var streamWriter = new StreamWriter(_lastRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                };

                if (_lastRequest.HaveResponse)
                {
                    using (var response = _lastRequest.GetResponse())
                    {

                    }
                }
            }
            
            return result;
        }
    }
}
