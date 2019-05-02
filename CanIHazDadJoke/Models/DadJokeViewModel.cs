using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CanIHazDadJoke.Models
{
    public class DadJoke
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }

        [JsonProperty("status")]
        public HttpStatusCode Status {get; set;}

        public DadJoke(string id, string content, HttpStatusCode status)
        {
            this.Id = id;
            this.Joke = content;
            this.Status = status;
        }
    }
}
