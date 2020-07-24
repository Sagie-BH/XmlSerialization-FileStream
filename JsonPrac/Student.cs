using System.Collections.Generic;

namespace JsonPrac
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Actions { get; set; }

        public Student()
        {

        }
    }
}
