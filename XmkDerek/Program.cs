using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an animal object to save
            Animal ranAnimal = new Animal("Lion", 50, 100);

            // Serialize the object data to a file with a stream object that provides a view on the sequence of the bytes.
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);

            // Creating a binary formatter object
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            // Serializing and saving the object in the given path
            binaryFormatter.Serialize(stream, ranAnimal);

            stream.Close();

            // Deletes the browser data
            ranAnimal = null;


            // Read the object data from the file
            stream = File.Open("AnimalData.dat", FileMode.Open);

            binaryFormatter = new BinaryFormatter();

            // Deserializing the file as an "Animal" to ranAnimal object
            ranAnimal = (Animal)binaryFormatter.Deserialize(stream);

            Console.WriteLine(ranAnimal);
            stream.Close();

            // Changing the object properties for test
            ranAnimal.Name = "Tiger";
            ranAnimal.Height = 63;
            ranAnimal.Weight = 321;

            // XmlSerializer writes Animal object data as XML
            XmlSerializer Serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\Sagie\Pictures\MyDir\MyData\AnAnimal.xml"))
            {
                Serializer.Serialize(tw, ranAnimal);
            }
            // Deletes the browser data
            ranAnimal = null;

            // Deserialize from XML to the object
            XmlSerializer deSerializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\Sagie\Pictures\MyDir\MyData\AnAnimal.xml");
            object obj = deSerializer.Deserialize(reader);
            ranAnimal = (Animal)obj;
            reader.Close();

            Console.WriteLine(ranAnimal.ToString());


            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Sheep", 40, 120),
                new Animal("Cat", 10, 10),
                new Animal("Cow", 120, 720),
                new Animal("Camel", 220, 320),
            };
            // Serializing the animal list to the file
            using (Stream fs = new FileStream(@"C:\Users\Sagie\Pictures\MyDir\MyData\Animals.xml",FileMode.Create,FileAccess.Write))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Animal>));
                xmlSerializer.Serialize(fs, theAnimals);
            }
            // Deletes the data from the list
            theAnimals = null;

            XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fileStream = File.OpenRead(@"C:\Users\Sagie\Pictures\MyDir\MyData\Animals.xml"))
            {
                theAnimals = (List<Animal>)serializer.Deserialize(fileStream);
            }

            foreach (Animal a in theAnimals)
            {
                Console.WriteLine();
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }
}
