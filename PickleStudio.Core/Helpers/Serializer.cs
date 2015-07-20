using Newtonsoft.Json;
using System.IO;

namespace PickleStudio.Core.Helpers
{
    public class Serializer
    {
        public string Serialize<T>(T input)
        {
            return JsonConvert.SerializeObject(input);
        }

        public T Deserialize<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        public void SerializeToFile<T>(T input, string filePath)
        {
            var output = JsonConvert.SerializeObject(input);

            File.WriteAllText(filePath, output);
        }

        public T DeserializeFromFile<T>(string filePath)
        {
            var input = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(input);
        }
    }
}
