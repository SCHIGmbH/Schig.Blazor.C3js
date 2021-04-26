using Schig.Blazor.C3js.Models.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    [JsonConverter(typeof(HideOptionsJsonConverter))]
    public class HideOptions : IEquatable<HideOptions>
    {
        public bool IsHidden { get; set; } = false;

        /// <summary>
        /// Array of data keys for which corresponding data should be hidden.
        /// </summary>
        public string[] HiddenDataKeys { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as HideOptions);
        }

        public bool Equals(HideOptions other)
        {
            return other != null &&
                   IsHidden == other.IsHidden &&
                   EqualityComparer<string[]>.Default.Equals(HiddenDataKeys, other.HiddenDataKeys);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsHidden, HiddenDataKeys);
        }
    }
}