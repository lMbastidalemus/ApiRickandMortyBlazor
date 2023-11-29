using Newtonsoft.Json;

namespace ApiRickandMorty.Model
{
    public class Personajes
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("species")]
        public string species { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }
        [JsonProperty("results")]

        public List<object> results { get; set; }

        [JsonProperty("info")]
        public Info info { get; set; }
    }
}
