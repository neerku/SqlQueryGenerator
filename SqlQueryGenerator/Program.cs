using Newtonsoft.Json;
using SqlQueryGenerator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlQueryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputJson = ReadJson();
            var input = JsonConvert.DeserializeObject<PrimaryTable>(inputJson);
            var queryGenerator = new QueryGenerator();
            var output = queryGenerator.GenerateQuery(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        public static string ReadJson()
        {
            var binDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = $"\\input.json";
            var inputJson = File.ReadAllText(binDirectory + filePath);
            return inputJson;
        }
    }
}
