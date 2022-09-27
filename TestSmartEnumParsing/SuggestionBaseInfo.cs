using Newtonsoft.Json;

namespace PL.Dadata.Contracts.Models.Suggestions
{
    public class SuggestionBaseInfo<T>
        where T: new()
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    
        [JsonProperty("unrestricted_value")]
        public string UnrestrictedValue { get; set; }
    
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}