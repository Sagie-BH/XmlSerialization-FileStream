using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(Student.GetAllStudents());

            // Order by the first name then ordering the grage
            students = students.OrderBy(x => x.Name).ThenByDescending(x => x.Grade).ToList();

            // Where searches by a boolean statement
            List<Student> boys = students.Where(student => student.IsMale == true).ToList();

            Console.WriteLine("All students:");
            students.ForEach(s => Console.WriteLine(s.ToString()));

            Console.WriteLine("\nOnly boys");
            boys.ForEach(boy => Console.WriteLine(boy.ToString()));

            // Girls sum of grades
            int sumOfGrades = students.Where(x => x.IsMale != true).Sum(x => x.Grade);

            Console.ReadLine();
        }
    }
}
