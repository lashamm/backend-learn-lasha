// int - integer მთელი რიცხვები
// double - ათწილადები
// string - სტრინგები
// char - ერთი სიმბოლო
// bool - boolean


//int x = 23;
//double y = 8.7;
//string str = "hello";
//char c = 'A';
//bool b = true;
//bool n = false; ././


string name;
string lastName;
int age;

Console.WriteLine("enter your name");
Console.WriteLine("enter your lastname");
Console.WriteLine("enter your age");

name = Console.ReadLine();
lastName = Console.ReadLine();
age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"hello {name} your lastname is {lastName} and you are {age} years old");