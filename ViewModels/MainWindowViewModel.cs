using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace cooljam.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        IWebAPI web = new WebAPI();
        Task<HttpResponseMessage> a;
        public string Greeting => getstats();

        public string getstats() {
            var k = this.web.GetPlayerFromAsync("ApRiL").Result.ToString();
            return k;
        }
    }
}
