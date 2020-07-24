using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"C:\Users\Sagie\Pictures\MyDir\MyData\StreamFile.txt";

            // Creates and open the file
            FileStream fs = File.Open(textFilePath, FileMode.Create);

            // Example string
            string randString = "Any random string I want to store";

            // Creating a byte  array for the "Write" method
            // Encoding the string into a byte array
            byte[] randStringEncoded = Encoding.Default.GetBytes(randString);

            // Writing the string to the file
            // (the byte array we want to write,     the starting position,      the length of the writing)
            fs.Write(randStringEncoded, 0, randStringEncoded.Length);


            // Moving the starting position back to 0 to read the text
            fs.Position = 0;

            // Getting the file info
            FileInfo file = new FileInfo(@"C:\Users\Sagie\Pictures\MyDir\MyData\StreamFile.txt");

            //Creating a new byte[]
            byte[] fileByteArray = new byte[file.Length];
            
            for (int i = 0; i < file.Length; i++)
            {
                // Reading each byte from the FileStream object
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            //Encoding the file byte array to string and writing on the console
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();


            Console.ReadLine();
        }
    }
}
