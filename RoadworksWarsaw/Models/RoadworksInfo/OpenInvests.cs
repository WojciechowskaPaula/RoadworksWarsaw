using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksInfo
{
    public class OpenInvests
    {
        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }
}