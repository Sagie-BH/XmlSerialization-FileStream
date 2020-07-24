using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    public class Person
    {
        public int Age { get; set; }
        public bool IsMale { get; set; }

        [XmlIgnore]
        public string IgnoredProperty { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        public void Save(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(Person));
                XML.Serialize(stream, this);
            }
        }
        public static Person LoadFromFile(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(Person));
                return (Person)XML.Deserialize(stream);
            }
        }
    }
}
