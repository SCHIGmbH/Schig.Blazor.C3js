using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class GridXAxisOptions
    {
        [JsonPropertyName("show")]
        public bool Show { get; set; } = false;

        [JsonPropertyName("lines")]
        public GridLineOptions[] Lines { get; set; } = null;
    }
}
