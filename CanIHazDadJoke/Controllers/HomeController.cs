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
       
        public IActionResult Index()
        {
            var client = new RestClient("https://icanhazdadjoke.com");
            var request = new RestRequest("/", Method.GET);

            IRestResponse response = client.Execute(request);
            var joke = JsonConvert.DeserializeObject<DadJoke>(response.Content);

            this.HttpContext.Response.Headers.Add("refresh", "10; url=" + Url.Action("index"));

            return View();
           // return View(joke);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(SearchModel search)
        {
            var client = new RestClient(BuildJokeSearchRequest(search.SearchTerm));
            var request = new RestRequest("/", Method.GET);

            IRestResponse response = client.Execute(request);
            var joke = JsonConvert.DeserializeObject<JokeSearchResults>(response.Content);

            return View(joke);
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
