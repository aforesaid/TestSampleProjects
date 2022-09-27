using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TestCustomValidator
{
    public class TestModel
    {
        [JsonConverter(typeof(TimestampDataFormatJsonConverter))]
        public DateTime DateNow { get; set; } = DateTime.Now;
    }
}