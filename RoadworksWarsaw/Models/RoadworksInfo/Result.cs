using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksInfo
{
    public class Result
    {
        [JsonPropertyName("IsError")]
        public string IsError { get; set; }

        [JsonPropertyName("ItemsCount")]
        public string ItemsCount { get; set; }

        [JsonPropertyName("Items")]
        public Items Items { get; set; }
    }
}
