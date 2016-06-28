using Icefrog;
using Nancy;

namespace icefrog.rainman
{
    public class RainmanWrapper : NancyModule
    {
        public Response GetRating(GameState gameState)
        {
            

            //Get[cards] = _ => {
            //    var contentBytes = Encoding.UTF8.GetBytes("OK");
            //    var response = new Response
            //    {
            //        ContentType = "text/plain",
            //        Contents = s => s.Write(contentBytes, 0, contentBytes.Length),
            //        StatusCode = HttpStatusCode.OK
            //    };
            //    return response;
            //};
            return null;
        }
    }
}
