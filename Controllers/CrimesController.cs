using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NFLCrimeStats.Models;
using System.Linq;

namespace NFLCrimeStats.Controllers
{
    public class CrimesController : Controller
    {

        private NFLHttpClient _httpClient;

        public CrimesController(NFLHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            List<CrimeModel> crimes = new List<CrimeModel>();
            
            string url = "crime";

            using (HttpResponseMessage response = await _httpClient.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    crimes = await response.Content.ReadAsAsync<List<CrimeModel>>();

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

            return View(crimes);
        }

        public async Task<IActionResult> TopPlayers(string crime)
        {
            List<PlayerModel> players = new List<PlayerModel>();
            string url = $"crime/topPlayers/{crime}";

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
            ViewData["Crime"] = crime;

            return View(players);
        }

        public async Task<IActionResult> PlayerCrimes(string playerName, string crime)
        {
            List<PlayerCrimes> crimes = new List<PlayerCrimes>();
            string url = $"player/arrests/{playerName}";

            using (HttpResponseMessage response = await _httpClient.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    crimes = await response.Content.ReadAsAsync<List<PlayerCrimes>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            ViewData["Crime"] = crime;

            return View(crimes);
        }

        public async Task<IActionResult> PlayerCrimesAll(string playerName)
        {
            List<PlayerCrimes> crimes = new List<PlayerCrimes>();
            string url = $"player/arrests/{playerName}";

            using (HttpResponseMessage response = await _httpClient.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    crimes = await response.Content.ReadAsAsync<List<PlayerCrimes>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

            return View(crimes);
        }



    }
}