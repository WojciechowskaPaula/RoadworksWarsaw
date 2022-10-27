using System.Text.Json;
using System.Text.Json.Serialization;

namespace RoadworksWarsaw.Models.RoadworksDetails
{
    public class Result
    {
        [JsonPropertyName("IsError")]
        public string IsError { get; set; }

        [JsonPropertyName("ItemsCount")]
        public string ItemsCount { get; set; }

        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("InvestDesc")]
        public object InvestDesc { get; set; }

        [JsonPropertyName("InvestName")]
        public string InvestName { get; set; }

        [JsonPropertyName("CompanyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("CompanyID")]
        public string CompanyID { get; set; }

        [JsonPropertyName("Street")]
        public string Street { get; set; }

        [JsonPropertyName("DistrictID")]
        public string DistrictID { get; set; }

        [JsonPropertyName("From")]
        public string From { get; set; }

        [JsonPropertyName("To")]
        public string To { get; set; }

        [JsonPropertyName("CategoryId")]
        public string CategoryId { get; set; }

        [JsonPropertyName("InvestNumber")]
        public string InvestNumber { get; set; }

        [JsonPropertyName("StartDate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("EndDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("CreationDate")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("CoorindationFinshed")]
        public string CoorindationFinshed { get; set; }

        [JsonPropertyName("GuaranteeFrom")]
        public GuaranteeFrom GuaranteeFrom { get; set; }

        [JsonPropertyName("GuaranteeTo")]
        public GuaranteeTo GuaranteeTo { get; set; }

        [JsonPropertyName("GeoJson")]
        public string GeoJson { get; set; }

        public GeoJson Geo => JsonSerializer.Deserialize<GeoJson>(GeoJson);

    }
}
