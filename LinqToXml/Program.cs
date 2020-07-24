using System.Xml.Linq;
namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a XMLDocument
            XDocument xmlDocument = new XDocument(

               // Creating a xml declaration class - the first line with the xml details
               new XDeclaration("1.0", "UTF-8", "Yes"),

               // Creating a xml Comment class
               new XComment("Any random comment about the XML"),

               // Creating the root element class
               new XElement("Students",

                     // Creating a child element to "Students" with an attribute name "ID" with value = 101
                     new XElement("Student", new XAttribute("ID", 101),

                        // Creating properties / child elements to the "Student" with tags ("Name") and value (string - "Sagie")
                        new XElement("Name", "Sagie"),
                        new XElement("Gender", "Male"),
                        new XElement("Grade", "100")),

                      // Creating more students
                      new XElement("Student", new XAttribute("ID", 102),
                        new XElement("Name", "Avi"),
                        new XElement("Gender", "Male"),
                        new XElement("Grade", "90")),

                       new XElement("Student", new XAttribute("ID", 103),
                        new XElement("Name", "Miri"),
                        new XElement("Gender", "Female"),
                        new XElement("Grade", "99")
                )));
            xmlDocument.Save(@"C:\Users\Sagie\Pictures\MyDir\MyData\xmlXML.xml");
        }
    }
}
