using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLinkToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load(@"C:\Users\Sagie\source\repos\FirstXml\ClassLinkToXml\Emps.xml");

            // Creating a root element - parent
            XElement root = doc.Root;

            Console.WriteLine("Employees List:\n");
            // Creating variables for each emp element tag
            foreach (XElement empTag in root.Elements())
            {
                string id = empTag.Element("EmpId").Value;
                string name = empTag.Element("Name").Value;
                var phoneNumbers = empTag.Elements("Phone");
                string allPhoneNumbers = "";

                // Getting each phone type and value through looping the phoneNumbers child elements
                foreach(XElement phone in phoneNumbers)
                {
                    allPhoneNumbers +="\t" + phone.Attribute("Type").Value + ":" + phone.Value + "\n";
                }

            Console.WriteLine($"Employee ID: {id}\n" +
                $"Name: {name}\n Phone Numbers:\n {allPhoneNumbers}");
            }
            Console.ReadLine();
        }
    }
}
