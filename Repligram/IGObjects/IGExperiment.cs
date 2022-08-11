using Newtonsoft.Json;
using System.Collections.Generic;

namespace Repligram.IGObjects
{
    public class IGExperiment
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("additional_params")]
        public List<string> AdditionalParams { get; set; }

        [JsonProperty("params")]
        public List<IGParam> Params { get; set; }
    }

    public class IGExperimentResponse
    {
        [JsonProperty("experiments")]
        public List<IGExperiment> Experiments { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}