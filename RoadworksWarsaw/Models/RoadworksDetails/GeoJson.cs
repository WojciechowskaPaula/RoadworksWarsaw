using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksDetails
{
    public class GeoJson
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        public List<List<double>> Coordinates { get; set; }
    }
}
