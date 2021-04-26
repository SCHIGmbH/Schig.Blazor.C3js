using Schig.Blazor.C3js.Models.JsonConverters;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Schig.Blazor.C3js.Models
{
    [JsonConverter(typeof(ColumnsCollectionJsonConverter))]
    public class ColumnsCollection : IEquatable<ColumnsCollection>
    {
        public string Key { get; set; }
        public object[] Values { get; set; }

        public ColumnsCollection()
        {
            Values = Array.Empty<object>();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ColumnsCollection);
        }

        public bool Equals(ColumnsCollection other)
        {
            return other != null &&
                   Key == other.Key &&
                   EqualityComparer<object[]>.Default.Equals(Values, other.Values);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Values);
        }
    }
}
