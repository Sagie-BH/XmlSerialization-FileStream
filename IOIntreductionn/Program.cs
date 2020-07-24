using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IOIntreduction
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");

            DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\Sagie\Pictures\MyDir");

            Console.WriteLine("Directory Full Name:" + myDir.FullName);
            Console.WriteLine("Directory Name: " + myDir.Name);
            Console.WriteLine("Directory Parent: " + myDir.Parent);
            Console.WriteLine("Directory attributes: " + myDir.Attributes);
            Console.WriteLine("Directory Creation Time: " + myDir.CreationTime);


            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Sagie\Pictures\MyDir\MyData");

            // Creates the folder
            dataDir.Create();

            // Deletes the folder
            //dataDir.Delete();

            string[] numbers = { "One", "Two", "Three", "Four", "Five" };

            string textFilePath = @"C:\Users\Sagie\Pictures\MyDir\MyData\MyNumbers.txt";


            // Writes an array of string to the file
            File.WriteAllLines(textFilePath, numbers);

            // Reads all the string from the file
            foreach(string num in File.ReadLines(textFilePath))
            {
                // Displays each string on the console
                Console.WriteLine($"Number : {num}");
            }


            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\Sagie\Pictures\MyDir\MyData");

            // Creates a FileInfo array from texts file found in the DirectoryInfo - ends in .txt
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            // Shows number of text Files
            Console.WriteLine($"\n\nMatches : {txtFiles.Length}");


            // Looping in the files gathered by the GetFiles method 
            foreach(FileInfo file in txtFiles)
            {
                // Writing each file name and length
                Console.WriteLine($"File Name: {file.Name}\t File Length: {file.Length}");
            }

            Console.ReadLine();
        }
    }
}
