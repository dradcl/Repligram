using Newtonsoft.Json;

namespace Repligram.IGObjects
{
    // Used for default return status
    public class IGStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IGLogStatus
    {
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("config")]
        public string Config { get; set; }

        [JsonProperty("config_owner_id")]
        public string ConfigOwnerID { get; set; }

        [JsonProperty("app_data")]
        public object AppData { get; set; }
    }
}