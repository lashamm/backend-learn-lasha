//                        მესამე გაკვეთილი




int n = 5;
for (int i = 1; i < n; i++)
{
    Console.WriteLine($"{i*i*i}");
}

//int n = 10;
//int sum = 0;
//double avarage;
//Console.WriteLine("enter numbers");
//for (int i = 0; i < n + 1; i++)
//{
//    Console.WriteLine($"enter number{i}: ");
//    int x = Convert.ToInt32(Console.ReadLine());
//    sum += x;
//}
//avarage = (double)sum / n;
//Console.WriteLine($"sum is {sum} and avarage is avarage is {avarage}");


//int finalNum = 0;
//for(int firstNum = 10; firstNum > finalNum; firstNum--)
//{
//    Console.WriteLine(firstNum);
//}   

//int tryCount = 20;
//for (int i = 1; i < tryCount + 1; i++){
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//for ( int i = 0; i < 3; i++)
//{
//    Console.WriteLine("enter letter");
//    char symbol = Convert.ToChar(Console.ReadLine());

//    if (char.IsLetter(symbol))
//    {
//        if ("aeiou".Contains(char.ToLower(symbol)))
//        {
//            Console.WriteLine("vowel");
//        }
//        else
//        {
//            Console.WriteLine("consonant");
//        }
//        break;
//    }
//    else
//    {
//        Console.WriteLine("not a letter");
//    }

//}


//while (true)
//{
//    Console.WriteLine("enter letter");
//    char symbol = Convert.ToChar(Console.ReadLine());

//    if (char.IsLetter(symbol))
//    {
//        if ("aeiou".Contains(char.ToLower(symbol)))
//        {
//            Console.WriteLine("vowel");
//        }
//        else
//        {
//            Console.WriteLine("consonant");
//        }
//        break;
//    }
//    else
//    {
//        Console.WriteLine("not a letter");
//    }

//}
//


















//                     მეორე გაკვეთილი


//Console.WriteLine("enter first num");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter second num");
//int secondNumber = Convert.ToInt32(Console.ReadLine());
//Console.Clear();

//int sum = firstNumber + secondNumber;
//int subtraction = firstNumber - secondNumber;
//int multiplication = firstNumber * secondNumber;
//int devide = firstNumber / secondNumber;
//int module = firstNumber % secondNumber;

//Console.Write($"sum of {firstNumber} and {secondNumber} is {sum} " +
//    $"subtraction of {firstNumber} and {secondNumber} is {subtraction} " +
//    $"multiplication of {firstNumber} and {secondNumber} is {multiplication} " +
//    $"{firstNumber} devided by {secondNumber} is {devide} " +
//    $"{firstNumber}s module of {secondNumber} is {module} ");
//Console.WriteLine("press anything to exit");
//Console.Clear();


//int x = 10;
//x += 2; // x = x + 2
//x -= 2; // x = x - 2
//x *= 2; // x = x * 2
//x /= 2; // x = x / 2
//x %= 2; // x = x % 2


//bool b = true && false; // დას(&&) შემთხვევაში თუ ერთერთი false არის მაშინ აბრუნებს false
//b = true && true; // true
//b = false && false; // false
//b = 13 > 0 || 13 < 0; // ანს(||) შემთხვევაში თუ ერთერთი true არის მაშინ აბრუნებს true
//b = false || false; // false
//b = true || false; // true
//b = true || true; // true


//char c = 'x';
//int x = c;
//c = (char)x;

//string n = "32";
//int x2 = c;
//x2 = Convert.ToInt32(n);

//Console.WriteLine("enter num");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num > 0)
//{
//    Console.WriteLine("num is positive");
//}
//else if (num == 0)
//{
//    Console.WriteLine("num is 0");
//}
//else
//{
//    Console.WriteLine("num is negative");
//}

//Console.WriteLine("enter num");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("luwi");
//}
//else
//{
//    Console.WriteLine("kenti");
//}

//int age;
//Console.WriteLine("enter age");
//age = Convert.ToInt32(Console.ReadLine());

//if (age < 18)
//{
//    Console.WriteLine("you are under 18");
//}
//else if (age >= 18 && age < 60)
//{
//    Console.WriteLine("you are between 18 and 60");
//}
//else if (age >= 60)
//{
//    Console.WriteLine("you are over 60");
//}
//else {
//    Console.WriteLine("invalid age");
//}

//int weekDay;
//string result;
//Console.WriteLine("enter any day from a moth");
//weekDay = Convert.ToInt32(Console.ReadLine());
//switch (weekDay % 7)
//{
//	case 1: result = "monday"; break;
//        case 2: result = "tuesday"; break;
//        case 3: result = "wednesday"; break;
//        case 4: result = "thursday"; break;
//        case 5: result = "friday"; break;
//        case 6: result = "saturday"; break;
//        case 7: result = "sunday"; break;
//    default:
//        result = "invalid day";
//        break;
//}
//Console.WriteLine($"day {weekDay} is {result}");


//Console.WriteLine("enter your grade");
//int grade = Convert.ToInt32(Console.ReadLine());

//if (grade > 91 || grade <= 100)
//{
//    Console.WriteLine("your grade is A+");
//}
//else if (grade > 81 && grade <= 90)
//{
//    Console.WriteLine("your grade is A");
//}
//else if (grade > 71 && grade <= 80)
//{
//    Console.WriteLine("your grade is B+");
//}
//else if (grade > 61 && grade <= 70)
//{
//    Console.WriteLine("your grade is B");
//}
//else if (grade > 51 && grade <= 60)
//{
//    Console.WriteLine("your grade is C+");
//}
//else if (grade > 41 && grade <= 50)
//{
//    Console.WriteLine("your grade is C");
//}
//else if (grade > 31 && grade <= 40)
//{
//    Console.WriteLine("your grade is D+");
//}
//else if (grade > 21 && grade <= 30)
//{
//    Console.WriteLine("your grade is D");
//}
//else if (grade >= 0 && grade <= 20)
//{
//    Console.WriteLine("your grade is F");
//}
//else
//{
//    Console.WriteLine("invalid grade");
//}

//                     პირველი გაკვეთილი


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


//string name;
//string lastName;
//int age;

//Console.WriteLine("enter your name");
//Console.WriteLine("enter your lastname");
//Console.WriteLine("enter your age");

//name = Console.ReadLine();
//lastName = Console.ReadLine();
//age = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine($"hello {name} your lastname is {lastName} and you are {age} years old");

