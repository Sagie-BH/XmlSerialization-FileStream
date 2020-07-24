namespace XmlLinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public int Grade { get; set; }

        public static Student[] GetAllStudents()
        {
            Student[] students = new Student[6];
            students[0] = new Student { Id = 100, Name = "Hana", Grade = 100, IsMale = false };
            students[1] = new Student { Id = 101, Name = "Yossi", Grade = 80, IsMale = true };
            students[2] = new Student { Id = 102, Name = "Yael", Grade = 74, IsMale = false };
            students[3] = new Student { Id = 103, Name = "Avi", Grade = 99, IsMale = true };
            students[4] = new Student { Id = 104, Name = "Sara", Grade = 88, IsMale = false };
            students[5] = new Student { Id = 105, Name = "Tipesh", Grade = 66, IsMale = true };
            return students;
        }
    }
}
