//                       მეცხრე გაკვეთილი

using backend1.Mocdels;

Person person = new Person(1, "Lasha", new DateTime(2008, 11, 19), "Maisuradze");
person.CalculateAge();

Teacher teacher = new Teacher("Giorgi", "Math", new DateTime(1990, 5, 20), 10);
teacher.Teach();

Student student = new Student(1, "Cotne", 15, "10th Grade");
student.study();













//                        მერვე გაკვეთილი
//using backend1.Mocdels;
//using backend1.Enums;

////Car car = new Car(CarBrand.Subaru, "Impreza WRX STI", new DateTime(2004,06,16), 9500, "Blue", "Japan");

////car.Print();

//Book book = new Book("Title", "Author", "000", Genre.Historical, new DateTime(1988,11,24 ), 13);

//book.PrintBook();




////                   მეშვიდე გაკვეთილი


//using backend1;

//Users user = new Users();

//user.Name = "Lasha";
//user.Name = "Giorgi";

//Users user1 = new Users(
//    "name",
//    "lastName",
//    "email",
//    DateTime.Now
//    );
//Users user2 = new Users(
//    "Lasha",
//    "Maisuradze",
//    "test@gmail.com",
//    new DateTime(2008, 11, 19)
//    );
//;
//user2.Print();








//                           მეექვსე გაკვეთილი



//int a = 13;
//int b = 32;
//swap(ref a, ref b);
//Console.WriteLine($"a = {a}, b = {b}");

//static void swap(ref int x, ref int y)
//{
//    (x, y) = (y, x);
//}





//using System.Diagnostics.CodeAnalysis;
//using System.Threading.Channels;

//int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//countEvens(numbers);
//static void countEvens(int[] numbers)
//{
//    int even = 0;
//    int sum = 0;
//    foreach (int i in numbers)
//    {
//        if (i % 2 == 0)
//        {
//            even++;
//            sum += even;
//        }
//    }
//}

//using System.Diagnostics;

//int num;
//static int fibonachi(int n)
//{
//    //    int first = 0;
//    //    int second = 1;
//    //    int result = 0;
//    //    for (int i = 0 ; i < n; i++)
//    //    {
//    //        result = first + second;
//    //        first = second;
//    //        second = result;
//    //    }
//    //    return result;

//    //            ან 

//    if (n == 1) return 0;
//    if (n == 2) return 1;
//    return fibonachi(n - 1) + fibonachi(n - 2);
//}

//Console.WriteLine("Enter num");
//num = Convert.ToInt32(Console.ReadLine());
//int fib = fibonachi(num);
//Console.WriteLine(fib);





//string str = "Welcome to step academy";
//int count = CountSpaces(str);
//Console.WriteLine(count);
//static int CountSpaces(string text) 
//{
//int result = 0;
//foreach(char item  in text)
//{
//    if(item == ' ')
//    {
//        result++;
//    }
//}
//return result;

//   ან

//return text.Split(' ').Length - 1;
//}


//using System.Threading.Channels;

//static double Summary(double x, double y)
//{
//    return x+y;
//}

//int num;
//int num2;
//Console.WriteLine("Enter num 1");
//num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter num 2");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.Clear();

//Console.WriteLine(Summary(num,num2));








//                         მეხუთე გაკვთილი


//string regulation = "This is a bad text with a bad word and it looks ugly and awful";
//string[] words = { "bad", "ugly", "awful" };

//foreach (var word in words)
//{
//    regulation = regulation.Replace(word, new string('*', word.Length));
//}
//Console.WriteLine(regulation);


//string regulation = "This is a bad text with a bad word";
//string badWord = "bad";

//regulation = regulation.Replace(badWord, new string('*', badWord.Length));
//Console.WriteLine(regulation);




//string text = "This is a very long text tgat nust be shortened";
//string shortText = text.Substring(0, 20) + "...";

//Console.WriteLine(shortText);





//string fullName = "    LaSha        MAisuradZe     ";

//string firstName;
//string lastName;
//string userName;

//string[] names = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//firstName = names[0];
//lastName = names[1];

//userName = firstName[0] +"." + " " + lastName;

//Console.WriteLine(userName.ToLower());






//string text = "this method allows fpr robust etc...";
//var words = text.Split(' ');
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}


//using System.Text;
//string text = "Hello, World!";
//string subString = text.Substring(5, 3);
//StringBuilder stringBuilder = new StringBuilder();
//stringBuilder.Append(subString);
//stringBuilder.Append(' ');
//stringBuilder.Append("C#");
//stringBuilder.Append("Python");

//string result = stringBuilder.ToString();
//Console.WriteLine(result);




//string mail;
//string mail2;
//Console.WriteLine("Enter your Mail");
//mail = Console.ReadLine() ?? string.Empty;
//Console.WriteLine("Reapeat Mail");
//mail2 = Console.ReadLine() ?? string.Empty;

//if (mail.Equals(mail2, StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("Mail is correct");
//}
//else
//{
//    Console.WriteLine("Mail is not correct");
//}







//                           მეოთხე გაკვეთილი

// მასივი

//int[] number = new int[20]; // მასივი 5 ელემენტიანი
//number[0] = 13; // მასივის პირველი ელემენტი
//number[1] = 14; // მასივის მეორე ელემენტი
//number[19] = 15;
//Console.WriteLine(number[0]);
//Console.WriteLine(number[1]);
//Console.WriteLine(number[19]);

//string[] names = new string[5];
//names[0] = "lasha";
//names[1] = "giorgi";
//names[2] = "nini";
//names[3] = "nata";
//names[4] = "cotne";

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//string[] names = new string[5];

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine("Enter name");
//    names[i] = Console.ReadLine() ?? string.Empty;
//}
//Console.Clear();
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//int[,] array = new int[3, 4];
//Random random = new Random();
//for (int i = 0; i < array.GetLength(0); i++)
//{

//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = random.Next(1, 101);
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + "\t");
//    }
//    Console.WriteLine();
//}


//char[] grades = new char[6];

//foreach (char c in grades)
//{
//}

//int x = 5;
//int y = x;
//x++;
//Console.WriteLine(x);
//Console.WriteLine(y);

//int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
//int[] arr2 = arr1;
//arr1[1] = 3;
//Console.WriteLine(arr2[1]);

//int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
//int[] arr2 = new int[arr1.Length]; 
//arr2 = arr1;

//for (int i = 0; i < arr1.Length; i++)
//{
//    arr2[i] = arr1[i];
//}

//arr1[2] = 10;
//Console.WriteLine(arr2[2]);









//                        მესამე გაკვეთილი


//int n = 5;
//for (int i = 0; i < n; i++)
//{
//    Console.Write(new string(' ', n - i));
//	for (int j = 0; j < i + 1; j++)
//	{
//        Console.Write($"{j + 1}");
//	}
//    Console.WriteLine();
//}

//int n = 5;

//do
//{
//    Console.WriteLine("enter positive number: ");
//    n = Convert.ToInt32(Console.ReadLine());
//} while (n <= 0);

//int n = 5;
//for (int i = 1; i < n; i++)
//{
//    int cube = (int)Math.Pow(i, 3);
//    Console.WriteLine($"{cube}");
//}

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

