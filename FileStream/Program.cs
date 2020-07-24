using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFileStream
{
    /// <summary>
    /// FileStream is an object that provides a Stream for a file,
    /// supporting both synchronous and asynchronous read and write operations.
    /// </summary>
    class Program
    {
        // Creating a file with binary Encoding
        static void WriteFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            // Checking if the file is writeble
            if (fs.CanWrite)
            {
                // Converting a string into a byte[]
                byte[] buffer = Encoding.UTF8.GetBytes("Buff");
                // Writing the byte[] to the new file using FileStream
                fs.Write(buffer, 0, buffer.Length);
            }
            // "Flushing" all the stored FileStream data (byte[]) to the file
            fs.Flush();
            fs.Close();
        }
        static void ReadFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[(byte)fs.Length];
            int bytesRead = fs.Read(buffer, 0, buffer.Length);

            Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));

            fs.Close();
        }
        static void Main(string[] args)
        {
            string FileName = @"C:\Users\Sagie\Pictures\test.txt";

            WriteFile(FileName);

            ReadFile(FileName);

            Console.Read();
        }
    }
}
