using Microsoft.AspNetCore.Mvc;
using CanIHazDadJoke.Models;
using RestSharp;
using Newtonsoft.Json;
using System.Linq;

namespace CanIHazDadJoke.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            HomeModel model = new HomeModel(GetRandomDadJoke());

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(string searchTerm)
        {
           JokeSearchResults searchObj = GetJokesByTextSearch(searchTerm);
            var sortedResults = searchObj.Results.OrderBy(q => q.Joke.Split(' ').Length).ToList();
            searchObj.Results = sortedResults;

            HomeModel model = new HomeModel(GetRandomDadJoke(), searchTerm, searchObj);

            return View(model);
        }


        [HttpGet]
        public string DadJoke()
        {
            return GetRandomDadJoke().Joke;
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
            var searchClient = new RestClient($"https://icanhazdadjoke.com/search?page=1&limit=30&term={searchTerm}");
            var searchRequest = new RestRequest("/", Method.GET);

            IRestResponse searchResponse = searchClient.Execute(searchRequest);
            var searchResults = JsonConvert.DeserializeObject<JokeSearchResults>(searchResponse.Content);

            return searchResults;
        }
    }
}
