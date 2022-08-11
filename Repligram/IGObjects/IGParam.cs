using Newtonsoft.Json;

namespace Repligram.IGObjects
{
    public class IGParam
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}