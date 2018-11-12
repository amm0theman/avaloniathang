using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;


namespace cooljam {
    interface IWebAPI {
        Task<HttpResponseMessage> GetPlayerFromAsync(string playername);
    }
}