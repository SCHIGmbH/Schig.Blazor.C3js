using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    public class ChartData : IEquatable<ChartData>
    {
        [JsonPropertyName("url")]
        public string Url{ get; set; } = null;

        /// <summary>
        /// Translated to data.json in C3js.
        /// </summary>
        [JsonPropertyName("json")]
        public object[] DataObjects { get; set; } = null;

        public object[][] Rows { get; set; } = null;

        [JsonPropertyName("columns")]
        public ColumnsCollection[] Columns { get; set; } = null;

        [JsonPropertyName("mimeType")]
        public string MimeType{ get; set; } = null;

        [JsonPropertyName("keys")]
        public Keys Keys { get; set; } = null;

        [JsonPropertyName("x")]
        public string X { get; set; } = null;

        /// <summary>
        /// Key = column key, Value = x-values key
        /// </summary>
        [JsonPropertyName("xs")]
        public Dictionary<string, string> XS { get; set; } = null;

        [JsonPropertyName("xFormat")]
        public string XFormat { get; set; } = null;

        /// <summary>
        /// Key = column key, Value = data name
        /// </summary>
        [JsonPropertyName("names")]
        public Dictionary<string, string> Names { get; set; } = null;

        /// <summary>
        /// Key = column key, Value = class (with prefix "c3-target-")
        /// </summary>
        [JsonPropertyName("classes")]
        public Dictionary<string, string> Classes { get; set; } = null;

        [JsonPropertyName("groups")]
        public string[][] Groups { get; set; } = null;

        /// <summary>
        /// Key = column key, Value = side of yaxis ("y" or "y2")
        /// </summary>
        [JsonPropertyName("axes")]
        public Dictionary<string, string> Axes { get; set; } = null;

        [JsonPropertyName("type")]
        public string Type { get; set; } = "line";

        /// <summary>
        /// Key = column key, Value = chart type
        /// </summary>
        [JsonPropertyName("types")]
        public Dictionary<string, string> Types { get; set; } = null;

        [JsonPropertyName("labels")]
        public bool? ShowLabels { get; set; } = null;

        /// <summary>
        /// Sort order ("desc" [default], "asc" or null)
        /// </summary>
        [JsonPropertyName("order")]
        public string Order { get; set; } = null;

        /// <summary>
        /// Key = column key, Value = region configuration
        /// </summary>
        [JsonPropertyName("regions")]
        public Dictionary<string, ChartDataRegionOptions> Regions { get; set; } = null;

        /// <summary>
        /// Key = column key, Value = color code (e.g. #ff0000)
        /// </summary>
        [JsonPropertyName("colors")]
        public Dictionary<string, string> Colors { get; set; } = null;

        [JsonPropertyName("hide")]
        public HideOptions Hide{ get; set; } = null;

        [JsonPropertyName("empty")]
        public EmptyLabelTextOptions Empty { get; set; } = null;

        [JsonPropertyName("selection")]
        public SelectionOptions Selection { get; set; } = null;

        [JsonPropertyName("stack")]
        public StackOptions Stack { get; set; } = null;

        public override bool Equals(object obj)
        {
            return Equals(obj as ChartData);
        }

        public bool Equals(ChartData other)
        {
            return other != null &&
                   Url == other.Url &&
                   EqualityComparer<object[]>.Default.Equals(DataObjects, other.DataObjects) &&
                   EqualityComparer<object[][]>.Default.Equals(Rows, other.Rows) &&
                   EqualityComparer<ColumnsCollection[]>.Default.Equals(Columns, other.Columns) &&
                   MimeType == other.MimeType &&
                   EqualityComparer<Keys>.Default.Equals(Keys, other.Keys) &&
                   X == other.X &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(XS, other.XS) &&
                   XFormat == other.XFormat &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(Names, other.Names) &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(Classes, other.Classes) &&
                   EqualityComparer<string[][]>.Default.Equals(Groups, other.Groups) &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(Axes, other.Axes) &&
                   Type == other.Type &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(Types, other.Types) &&
                   ShowLabels == other.ShowLabels &&
                   Order == other.Order &&
                   EqualityComparer<Dictionary<string, ChartDataRegionOptions>>.Default.Equals(Regions, other.Regions) &&
                   EqualityComparer<Dictionary<string, string>>.Default.Equals(Colors, other.Colors) &&
                   EqualityComparer<HideOptions>.Default.Equals(Hide, other.Hide) &&
                   EqualityComparer<EmptyLabelTextOptions>.Default.Equals(Empty, other.Empty) &&
                   EqualityComparer<SelectionOptions>.Default.Equals(Selection, other.Selection) &&
                   EqualityComparer<StackOptions>.Default.Equals(Stack, other.Stack);
        }

        public override int GetHashCode()
        {
            HashCode hash = new();
            hash.Add(Url);
            hash.Add(DataObjects);
            hash.Add(Rows);
            hash.Add(Columns);
            hash.Add(MimeType);
            hash.Add(Keys);
            hash.Add(X);
            hash.Add(XS);
            hash.Add(XFormat);
            hash.Add(Names);
            hash.Add(Classes);
            hash.Add(Groups);
            hash.Add(Axes);
            hash.Add(Type);
            hash.Add(Types);
            hash.Add(ShowLabels);
            hash.Add(Order);
            hash.Add(Regions);
            hash.Add(Colors);
            hash.Add(Hide);
            hash.Add(Empty);
            hash.Add(Selection);
            hash.Add(Stack);
            return hash.ToHashCode();
        }
    }
}
