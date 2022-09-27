using System;
using Newtonsoft.Json;

namespace TestCustomValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = @"{""DateNow"": 1663921747}";
            var model = JsonConvert.DeserializeObject<TestModel>(data);

            var stringModel = JsonConvert.SerializeObject(model);
            var model2 = JsonConvert.DeserializeObject<TestModel>(stringModel);
        }
    }
}