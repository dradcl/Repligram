using Newtonsoft.Json;
using System.Collections.Generic;

namespace Repligram.IGObjects
{
    public class IGPrefill
    {
        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("candidates")]
        public List<IGPrefillCandidate> Candidates { get; set; }
    }

    public class IGPrefillCandidate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class IGPrefillCandidateResponse
    {
        [JsonProperty("prefills")]
        public List<IGPrefill> Prefills { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}