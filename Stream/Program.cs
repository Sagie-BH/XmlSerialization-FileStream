using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a path string
            string textFilePath = @"C:\Users\Sagie\Pictures\MyDir\MyData\TextStream.txt";

            // Creating the file and the stream writer object
            StreamWriter sw = File.CreateText(textFilePath);

            // Writing random strings to the file
            sw.Write("More Writing");
            sw.WriteLine("\nAnother Line");

            sw.Close();

            StreamReader sr = File.OpenText(textFilePath);

            // Return the next char
            Console.WriteLine($"Peek: {Convert.ToChar(sr.Peek())}");

            // Reading the first line in the file
            Console.WriteLine($"First string: {sr.ReadLine()}");

            // Returning the StreamReader object to the begining
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // Displaying all the text in the file
            Console.WriteLine($"All the text:\n {sr.ReadToEnd()}");

            sr.Close();

            Console.ReadLine();
        }
    }
}
