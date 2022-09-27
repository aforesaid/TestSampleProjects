using System;
using Newtonsoft.Json;

namespace TestSmartEnumParsing.Converters
{
    public class TimestampDataFormatJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dateTime = (DateTime) value;
            serializer.Serialize(writer, dateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return reader.Value switch
            {
                null => null,
                DateTime dateTime => dateTime,
                long timeStamp => DateTimeOffset.FromUnixTimeMilliseconds(timeStamp).UtcDateTime,
                _ => throw new ArgumentException("Unsupported json value")
            };
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
