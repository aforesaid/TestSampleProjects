using System;
using System.IO;
using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Newtonsoft.Json;
using PL.Dadata.Contracts.Models.Suggestions;

namespace TestSmartEnumParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = File.ReadAllText("source.json");
                var content = JsonConvert.DeserializeObject<SuggestionBaseInfo<CompanyDataInfo>>(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public class JsonModel
    {
        public TestEnum MyValue { get; set; }
    }
    
    [JsonConverter(typeof(SmartEnumNameConverter<TestEnum,int>))]
    public abstract class TestEnum : SmartEnum<TestEnum>
    {
        public static TestEnum A = new AEnum();
        public static TestEnum B = new BEnum();

        protected TestEnum(string name, int value)
            : base(name, value)
        { }
        
        private sealed class AEnum : TestEnum
        {
            public AEnum() 
                : base("A", 0)
            { }
        }
        private sealed class BEnum : TestEnum
        {
            public BEnum() 
                : base("B", 1)
            { }
        }
    }
}