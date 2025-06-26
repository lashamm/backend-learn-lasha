using backend1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend1.Mocdels
{
    internal class Teacher : Person
    {
        public subject Subject { get; set; }
        public int Experience { get; set; }

        public Teacher() { }

        public Teacher(
            string name, 
            subject subject,
            int id,
            string surname,
            DateTime age, 
            int experience) : base(id, name, age, surname)
        {
            Subject = subject;
            Experience = experience;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}");
        }
    }
}
