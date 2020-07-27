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
            var inputJson = ReadJson("input.json");
            var input = JsonConvert.DeserializeObject<PrimaryTable>(inputJson);
            Console.WriteLine("************Output with Operators*******************");
            var queryGenerator = new QueryGenerator();
            var output = queryGenerator.GenerateQuery(input);
            Console.WriteLine(output);

            Console.WriteLine("************Output with JOINS*******************");
            inputJson = ReadJson("inputWithJoins.json");
            var inputWithJoins = JsonConvert.DeserializeObject<Query>(inputJson);
            output = queryGenerator.GenerateJoinQuery(inputWithJoins);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        public static string ReadJson(string filePath)
        {
            var binDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = $"\\{filePath}";
            var inputJson = File.ReadAllText(binDirectory + path);
            return inputJson;
        }
    }
}
