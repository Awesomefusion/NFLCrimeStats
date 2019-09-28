using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NFLCrimeStats.Models;

namespace NFLCrimeStats.Controllers
{
    public class TeamsController : Controller
    {
        private NFLHttpClient _httpClient;

        public TeamsController(NFLHttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            List<TeamModel> teams = new List<TeamModel>();
            string url = "team/";

            using (HttpResponseMessage response = await _httpClient.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    teams = await response.Content.ReadAsAsync<List<TeamModel>>();

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

            return View(teams);
        }

        public async Task<IActionResult> TeamTopPlayers(string team, string teamName)
        {
            List<PlayerModel> players = new List<PlayerModel>();
            string url = $"team/topPlayers/{team}";

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

            ViewData["Team"] = teamName;

            return View(players);
        }

    }
}