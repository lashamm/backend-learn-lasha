namespace backend1.Mocdels
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public string Surname { get; set; }

        public Person() { }

        public Person(
            int id, 
            string name, 
            DateTime age, 
            string surname
            )
        {
            Id = id;
            Name = name;
            Age = age;
            Surname = surname;
        }

        public void CalculateAge() { 
                int age = DateTime.Now.Year - Age.Year;
                if (DateTime.Now.DayOfYear < Age.DayOfYear)
                {
                    age--;
                }
                Console.WriteLine($"{Name} is {age} years old");
        }
    }
}
