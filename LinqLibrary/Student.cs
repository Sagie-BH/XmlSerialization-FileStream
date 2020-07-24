using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public bool IsMale { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>() {
                new Student { Id = 100, Name = "Hana", Grade = 100, LastName = "Cohen", IsMale = false },
                new Student { Id = 101, Name = "Yossi", Grade = 80, LastName = "James", IsMale = true },
                new Student { Id = 102, Name = "Yael", Grade = 74, LastName = "Parker", IsMale = false },
                new Student { Id = 103, Name = "Avi", Grade = 99, LastName = "Ben-Avi", IsMale = true },
                new Student { Id = 104, Name = "Sara", Grade = 88, LastName = "Geler", IsMale = false },
                new Student { Id = 105, Name = "Tipesh", Grade = 56, LastName = "Mamash", IsMale = true },
                new Student { Id = 102, Name = "Yael", Grade = 64, LastName = "Alon", IsMale = false } };
            return students;
        }
        public override string ToString()
        {
            return $"Student: {Name} {LastName}\tID: {Id}\tGrade: {Grade}\tIs Male: {IsMale}";
        }
    }
}
