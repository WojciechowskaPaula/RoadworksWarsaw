using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksInfo
{
    public class Items
    {
        [JsonPropertyName("InvestItem")]
        public List<InvestItem> InvestItem { get; set; }
    }
}
