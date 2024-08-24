using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeopixelControlDesktop
{
   public static class AdafruitIOService
    {
        public static async Task<string> SendValue(string value)
        {
          
            var obj = new JsonObject { value = value };
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");


            HttpClient client = new HttpClient();
            var response = await
                    client.PostAsync("https://io.adafruit.com/api/v2/webhooks/feed/4zVqBduBFcU7mFaj2y4KQwpx4DUe", data);

                string result = response.Content.ReadAsStringAsync().Result;


            return result;
        }
    }
}
