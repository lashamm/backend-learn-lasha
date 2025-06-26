using System.Xml;

namespace backend1.Mocdels
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Student() { }
        public Student(int id, string name, int age, string grade)
        {
            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void study() {
            Console.WriteLine($"{Name} is studying");
        }
    }
}
