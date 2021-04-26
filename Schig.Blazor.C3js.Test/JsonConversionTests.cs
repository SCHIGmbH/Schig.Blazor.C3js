using Schig.Blazor.C3js;
using Schig.Blazor.C3js.Models;
using Schig.Blazor.C3js.Models.JsInterop;
using Microsoft.AspNetCore.Components;
using Shouldly;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Schig.Blazor.C3.UnitTest
{
    public class JsonConversionTests
    {
        [Fact]
        public void ColumnsCollectionJsonConverterTest()
        {
            ColumnsCollection columnsStrings = new();
            ColumnsCollection columnsMixed = new();

            columnsStrings.Key = "x";
            columnsStrings.Values = new object[] { "2013-01-01", "2013-01-02", "2013-01-03", "2013-01-04" };

            columnsMixed.Key = "data1";
            columnsMixed.Values = new object[] { -30, 200, 100, 400 };

            ColumnsCollection[] columns = new ColumnsCollection[] { columnsStrings, columnsMixed };

            string json = JsonSerializer.Serialize(columns);

            json.ShouldBe("[[\"x\",\"2013-01-01\",\"2013-01-02\",\"2013-01-03\",\"2013-01-04\"],[\"data1\",-30,200,100,400]]");
        }

        [Fact]
        public void EmptyLabelTextJsonConverterTest()
        {
            EmptyLabelTextOptions emptyLabelText = new()
            {
                Text = "No Data!"
            };

            string json = JsonSerializer.Serialize(emptyLabelText);

            json.ShouldBe("{\"label\":{\"text\":\"No Data!\"}}");
        }

        [Fact]
        public void CullingFalseJsonConverterTest()
        {
            CullingOptions culling = new()
            {
                IsCulling = false,
                Max = 2
            };

            string json = JsonSerializer.Serialize(culling);

            json.ShouldBe("false");
        }

        [Fact]
        public void CullingTrueJsonConverterTest()
        {
            CullingOptions culling = new()
            {
                IsCulling = true,
                Max = 2
            };

            string json = JsonSerializer.Serialize(culling);

            json.ShouldBe("{\"max\":2}");
        }

        [Fact]
        public void CullingTrueDefaultJsonConverterTest()
        {
            CullingOptions culling = new()
            {
                IsCulling = true
            };

            string json = JsonSerializer.Serialize(culling);

            json.ShouldBe("{\"max\":10}");
        }

        [Fact]
        public void HideArrayPresentJsonConverterTest()
        {
            HideOptions hide = new()
            {
                HiddenDataKeys = new string[] { "data1", "data2" }
            };

            string json = JsonSerializer.Serialize(hide);

            json.ShouldBe("[\"data1\",\"data2\"]");
        }

        [Fact]
        public void HideArrayPresentTrueJsonConverterTest()
        {
            HideOptions hide = new()
            {
                IsHidden = true,
                HiddenDataKeys = new string[] { "data1", "data2" }
            };

            string json = JsonSerializer.Serialize(hide);

            json.ShouldBe("true");
        }

        [Fact]
        public void HideArrayPresentFalseJsonConverterTest()
        {
            HideOptions hide = new()
            {
                IsHidden = false,
                HiddenDataKeys = new string[] { "data1", "data2" }
            };

            string json = JsonSerializer.Serialize(hide);

            json.ShouldBe("[\"data1\",\"data2\"]");
        }

        [Fact]
        public void HideArrayMissingFalseJsonConverterTest()
        {
            HideOptions hide = new()
            {
                IsHidden = false
            };

            string json = JsonSerializer.Serialize(hide);

            json.ShouldBe("false");
        }

        // ----------------------------------------- Trial & Error -----------------------------------------------

        [Fact]
        public void SerializeDataObjectToJson()
        {
            ChartData data = new();
            ColumnsCollection columns = new();
            columns.Key = "x";
            columns.Values = new object[] { "2013-01-01", "2013-01-02", "2013-01-03", "2013-01-04" };

            data.Columns = new ColumnsCollection[] { columns };
            data.Type = "bar";
            data.Empty = new EmptyLabelTextOptions()
            {
                Text = "No Data!"
            };

            Dictionary<string, string> types = new()
            {
                { "data1", "bar" },
                { "data2", "spline" }
            };

            data.Types = types;

            ChartAxis axis = new()
            {
                X = new()
                {
                    Type = "timeseries"
                }
            };

            ElementReference elementReference = new("chartElementId");

            ChartConfiguration config = new(data, axis);

            ChartOptions options = new(elementReference, config);

            string json = JsonSerializer.Serialize(options);
        }
    }
}
