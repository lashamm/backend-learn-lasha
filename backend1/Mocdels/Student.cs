using System.Xml;

namespace backend1.Mocdels
{
    internal class Student : Person
    {
        public string Grade { get; set; }

        public Student() { }
        public Student(
            int id, 
            string name, 
            DateTime age, 
            string surname,
            string grade) : base(id, name, age, surname)
        {
           
            Grade = grade;
        }

        public void study() {
            Console.WriteLine($"{Name} is studying");
        }
    }
}
