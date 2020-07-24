using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JsonPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Sagie",
                Degree = "MC",
                Actions = new List<string>() { "Eating", "Sleeping", "Tennis" }
            };

            string strJsonRes = JsonConvert.SerializeObject(student);

            File.WriteAllText(@"C:\Users\Sagie\Pictures\MyDir\MyData\JsonStudent.json", strJsonRes);
        }
    }
}