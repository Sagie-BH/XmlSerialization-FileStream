using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 30;
            person.IsMale = true;
            person.Name = "Zoro";

            person.Save("SavedXMLFile.xml");

            Person loadedPerson = Person.LoadFromFile("SavedXMLFile.xml");
        }
    }
}
