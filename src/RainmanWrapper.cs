using Newtonsoft.Json.Linq;
using System.Text;

namespace Nancy.Simple
{
    public class RainmanWrapper : NancyModule
    {
        public Nancy.Response GetInfo()
        {
            Get["/"] = _ => {
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
