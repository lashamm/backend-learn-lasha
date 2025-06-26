using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend1.Mocdels
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public DateTime age { get; set; }
        public int Experience { get; set; }

        public Teacher() { }

        public Teacher(
            string name, 
            string subject, 
            DateTime age, 
            int experience)
        {
            Name = name;
            Subject = subject;
            this.age = age;
            Experience = experience;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}");
        }
    }
}
