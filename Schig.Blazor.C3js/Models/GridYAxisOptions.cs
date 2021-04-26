using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class GridYAxisOptions
    {
        [JsonPropertyName("show")]
        public bool Show { get; set; }

        [JsonPropertyName("lines")]
        public GridLineOptions[] Lines { get; set; }
    }
}
