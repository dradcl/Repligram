using Newtonsoft.Json;

namespace Repligram.IGObjects
{
    public class IGConfig
    {
        [JsonProperty("ig_android_carrier_signals_killswitch")]
        public IGConfigKillswitch Killswitch { get; set; }
    }

    public class IGConfigKillswitch
    {
        [JsonProperty("params")]
        public IGEnableResponse Params { get; set; }
    }

    public class IGConfigResponse
    {
        [JsonProperty("configs")]
        public IGConfig Configs { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}