using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XMLToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            // Loading the xml document to a XDocumnet object
            XDocument.Load(@"C:\Users\Sagie\Pictures\MyDir\MyData\StudXml.xml")
                // Descendats = IEnumerable, can't loop
                // Using ToList() method to loop on each child element ("Student")
                .Descendants("Student").ToList().ForEach(

                // Building the StringBuilder object
                // Adding the Attribute
                elementStudent => sb.Append("Student ID:" +
                                //Adding the elements with descriptions
                                elementStudent.Attribute("Id").Value + "\nName: " +
                                elementStudent.Element("Name").Value + "\nGrade: " +
                                elementStudent.Element("Grade").Value + "\nIs Male: " +
                                elementStudent.Element("Is_Male").Value + "\n\n"));

                                //? sb.Append("Male\n") : sb.Append("Female\n")));

            File.WriteAllText(@"C:\Users\Sagie\Pictures\MyDir\MyData\ConvertingToStringBuilder.txt", sb.ToString());
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
