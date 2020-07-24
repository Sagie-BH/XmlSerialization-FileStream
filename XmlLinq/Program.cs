using System.Linq;
using System.Xml.Linq;

namespace XmlLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "Yes"),
                new XComment("Student object to Xml"),

                // Creating the root element class
                new XElement("Students",

                    // Using a var as s object of student 
                    from student in Student.GetAllStudents()

                        // Creating a child element "Student" with a new attribute - student.Id
                    select new XElement("Student", new XAttribute("Id", student.Id),
                                
                                // Creating child elements to each student
                                new XElement("Name", student.Name),
                                new XElement("Grade", student.Grade),
                                new XElement("Is_Male", student.IsMale)
                )));

            xmlDocument.Save(@"C:\Users\Sagie\Pictures\MyDir\MyData\StudXml.xml");





            // Loadind a Xml file into a XDocument object
            XDocument myXmlDoc = XDocument.Load(@"C:\Users\Sagie\Pictures\MyDir\MyData\StudXml.xml");

                // Adding a new element into "Students" element
                myXmlDoc.Element("Students").Add(
                    // Creating a child element "Student" with a new attribute - student.Id
                    new XElement("Student", new XAttribute("Id", 110),
                        //Adding new properties to the new element
                        new XElement("Name", "Batman"),
                        new XElement("Grade", 666),
                        new XElement("Is_Male", true))
                    );

                // Adding a new element to the start of the file
            myXmlDoc.Element("Students").AddFirst(
                new XElement("Student", new XAttribute("Id", 99),
                    new XElement("Name", "Bite_The_Dust"),
                    new XElement("Grade", 1000),
                    new XElement("Is_Male", true)
                ));

                //Adding a new element in a specific location
            myXmlDoc.Element("Students")
                    // Searching the "Student" Element with a specific element attribute
                    //"Elements" creates an Ienumarable list
                .Elements("Student").Where(student => student.Attribute
                    // The method reads all the values as strings
                    // FirstOfDefault - returns 1 element
                ("Id").Value == "103").FirstOrDefault()

                // Adding the new element BEFORE the searched location
                .AddBeforeSelf(
                 new XElement("Student", new XAttribute("Id", 7652),
                    new XElement("Name", "Duhafit"),
                    new XElement("Grade", 12),
                    new XElement("Is_Male", false)
                ));

                // Changing an element value to Student element
            myXmlDoc.Element("Students").Elements("Student")
                .Where(x => x.Element("Name").Value == "Batman").FirstOrDefault()
                .SetElementValue("Grade", 100000);

                // Changing an element attribute
            myXmlDoc.Element("Students").Elements("Student")
                .Where(lol => lol.Attribute("Id").Value == "101").FirstOrDefault().SetValue(1);

            //myXmlDoc.Element("Student") 
            //    from student in myXmlDoc.Elements("Student")
            //    where student.Attribute("Id").Value =="102"

            myXmlDoc.Save(@"C:\Users\Sagie\Pictures\MyDir\MyData\MyXmlDoc.xml");

            // "Save" method have servel saving options
            myXmlDoc.Save(@"C:\Users\Sagie\Pictures\MyDir\MyData\MyXmlDocInOneLine.xml", SaveOptions.DisableFormatting);


            // Removing an element
            myXmlDoc.Root.Elements().Where(byeBye => byeBye.Attribute("Id").Value == "101").Remove();

            // Removing the xml comment
            myXmlDoc.Nodes().OfType<XComment>().FirstOrDefault().Remove();

            // Changing the xml comment
            myXmlDoc.Add(new XComment("A new Xml comment"));

            myXmlDoc.Save(@"C:\Users\Sagie\Pictures\MyDir\MyData\ChangedComments.xml");


        }
    }
}
