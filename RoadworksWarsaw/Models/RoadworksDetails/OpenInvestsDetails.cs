using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksDetails
{
    public class OpenInvestsDetails
    {
        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }
}