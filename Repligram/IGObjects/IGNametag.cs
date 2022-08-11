using Newtonsoft.Json;

namespace Repligram.IGObjects
{
    public class IGNametag
    {
        [JsonProperty("mode")]
        public int Mode { get; set; }

        [JsonProperty("gradient")]
        public int Gradient { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("selfie_sticker")]
        public int SelfieSticker { get; set; }
    }
}