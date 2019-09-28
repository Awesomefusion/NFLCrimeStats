using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NFLCrimeStats.Models;

namespace NFLCrimeStats.Controllers
{
    public class PlayersController : Controller
    {
        private NFLHttpClient _httpClient;

        public PlayersController(NFLHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            List<PlayerModel> players = new List<PlayerModel>();

            string url = "player";

            using (HttpResponseMessage response = await _httpClient.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    players = await response.Content.ReadAsAsync<List<PlayerModel>>();

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

            return View(players);
        }
    }
}