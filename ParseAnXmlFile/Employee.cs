using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAnXmlFile
{
    class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsMale { get; private set; }
        public Employee(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
