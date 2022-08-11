using Newtonsoft.Json;
using System.Collections.Generic;

namespace Repligram.IGObjects
{
    public class IGToken
    {
        [JsonProperty("carrier_name")]
        public string CarrierName { get; set; }

        [JsonProperty("carrier_id")]
        public int CarrierId { get; set; }

        [JsonProperty("ttl")]
        public int TTL { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }

        [JsonProperty("request_time")]
        public int RequestTime { get; set; }

        [JsonProperty("token_hash")]
        public string TokenHash { get; set; }

        [JsonProperty("rewrite_rules")]
        public List<string> RewriteRules { get; set; }

        [JsonProperty("enabled_wallet_defs_keys")]
        public List<string> EnabledWalletDefsKeys { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("zero_cms_fetch_interval_seconds")]
        public int ZeroCmsFetchIntervalSeconds { get; set; }

        [JsonProperty("carrier_signal_config")]
        public List<string> CarrierSignalConfig { get; set; }
    }

    public class IGTokenResponse
    {
        [JsonProperty("token")]
        public IGToken Token { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}