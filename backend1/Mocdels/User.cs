namespace backend1.Mocdels
{
    internal class Users
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; private set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public Users() { }
        public Users(
            string name,
            string lastName,
            string email,
            DateTime birthDate
            )
        {
            Name = name;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
        }

        public int getAge()
        {
            int result = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                result--;
            }
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, " +
                $"LastName: {LastName}, " +
                $"Mail: {Email}, " +
                $"Age: {getAge()}.");
        }
    }

}
