using System.ComponentModel;

namespace CanIHazDadJoke.Models
{
    public class SearchModel
    {
        [DisplayName("Search Term")]
        public string SearchTerm { get; set; }
    }
}
