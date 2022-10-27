using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksInfo
{
    public class InvestItem
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Street")]
        public string Street { get; set; }

        [JsonPropertyName("StartDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("EndDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("LastModifyDate")]
        public DateTime LastModifyDate { get; set; }

        public TimeSpan Duration => EndDate - StartDate;
    }
}

