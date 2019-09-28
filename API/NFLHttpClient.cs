using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NFLCrimeStats.Controllers
{
    public class NFLHttpClient
    {
        public HttpClient Client { get; set; }

        public NFLHttpClient(HttpClient client)
        {
            Client = client;
        }

    }
}
