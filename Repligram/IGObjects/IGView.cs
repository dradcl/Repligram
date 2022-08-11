using Newtonsoft.Json;
using System.Collections.Generic;

namespace Repligram.IGObjects
{
    public class IGViewResponse
    {
        [JsonProperty("ranking")]
        public List<IGView> Ranking { get; set; }

        [JsonProperty("entities")]
        public IGEntity Entities { get; set; }

        [JsonProperty("failed_view_names")]
        public List<string> FailedNames { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IGView
    {
        [JsonProperty("view_name")]
        public string ViewName { get; set; }

        [JsonProperty("score_map")]
        public IGScoreMap ScoreMap { get; set; }

        [JsonProperty("expiration_ms")]
        public long Expiration { get; set; }

        [JsonProperty("ranking_request_id")]
        public string RequestID { get; set; }
    }

    public class IGEntity
    {
        [JsonProperty("user")]
        public List<IGUser> User { get; set; }

        [JsonProperty("thread")]
        public List<object> Thread { get; set; }
    }

    // PLACEHOLDER: find an example response of this
    public class IGScoreMap
    {

    }
}