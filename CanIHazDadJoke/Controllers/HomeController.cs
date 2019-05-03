using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CanIHazDadJoke.Models;
using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CanIHazDadJoke.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var joke = GetRandomDadJoke();

            this.HttpContext.Response.Headers.Add("refresh", "10; url=" + Url.Action("index"));

            HomeModel model = new HomeModel(joke);

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(string searchTerm)
        {
            HomeModel model = new HomeModel(GetRandomDadJoke(), searchTerm, GetJokesByTextSearch(searchTerm));

            return View(model);
        }

        private DadJoke GetRandomDadJoke()
        {
            var client = new RestClient("https://icanhazdadjoke.com");
            var request = new RestRequest("/", Method.GET);

            IRestResponse response = client.Execute(request);
            var joke = JsonConvert.DeserializeObject<DadJoke>(response.Content);

            return joke;
        }

        private JokeSearchResults GetJokesByTextSearch(string searchTerm)
        {
            var searchClient = new RestClient(BuildJokeSearchRequest(searchTerm));
            var searchRequest = new RestRequest("/", Method.GET);

            IRestResponse searchResponse = searchClient.Execute(searchRequest);
            var searchResults = JsonConvert.DeserializeObject<JokeSearchResults>(searchResponse.Content);

            return searchResults;
        }

        private string BuildJokeSearchRequest(string searchTerm)
        {
            return $"https://icanhazdadjoke.com/search?page=1&limit=30&term={searchTerm}";
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
