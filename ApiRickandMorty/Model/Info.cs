using Newtonsoft.Json;

namespace ApiRickandMorty.Model
{
    public class Info
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("pages")]
        public int pages { get; set; }
        [JsonProperty("next")]
        public string next { get; set; }
        [JsonProperty("prev")]
        public object prev { get; set; }
    }
}
