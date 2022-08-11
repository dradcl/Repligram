using Newtonsoft.Json;

namespace Repligram.IGObjects
{
    public class IGEnableResponse
    {
        [JsonProperty("is_enabled")]
        public IGEnable IsEnabled { get; set; }
    }

    public class IGEnable
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }
}