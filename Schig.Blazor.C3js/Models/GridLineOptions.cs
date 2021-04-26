using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class GridLineOptions
    {
        [JsonPropertyName("value")]
        public decimal Value { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }
    }
}
