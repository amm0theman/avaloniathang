using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace cooljam {
    public class WebAPI : IWebAPI
    {
        public WebAPI() {
            client.DefaultRequestHeaders.Accept.Clear();
        }
        static HttpClient client = new HttpClient();
        public Task<HttpResponseMessage> GetPlayerFromAsync(string playername)
        {
            return Task.Run(() => {
                client.BaseAddress = new Uri("https://api.bf4stats.com/api/playerInfo?plat=pc&" + playername + "&output=json");
                Task<HttpResponseMessage> response;
                return response = client.GetAsync(client.BaseAddress);
            });
        }
    }
}