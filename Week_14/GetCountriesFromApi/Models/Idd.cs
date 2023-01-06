using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class Idd
    {
        [JsonPropertyName("root")]
        public string? Root { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
    }
}
