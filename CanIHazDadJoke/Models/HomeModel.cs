namespace CanIHazDadJoke.Models
{
    public class HomeModel
    {

        public DadJoke Joke { get; set; }

        public string SearchTerm { get; set; }

        public JokeSearchResults SearchResults {get; set;}

        public HomeModel(DadJoke joke)
        {
            this.Joke = joke;
        }

        public HomeModel(DadJoke joke, string searchTerm, JokeSearchResults searchResults)
        {
            this.Joke = joke;
            this.SearchTerm = searchTerm;
            this.SearchResults = searchResults;
        }
    }
}
