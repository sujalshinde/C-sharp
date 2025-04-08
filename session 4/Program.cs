// See https://aka.ms/new-console-template for more information

//Session 1 & 2-
//Console.WriteLine("Hello, World!");

////implicit type casting
//int a = 9;
//double b = a;
//Console.WriteLine(a);
//Console.WriteLine(b);

////explicit type casting
//double c = 78.90;
//int d = (int)c;
//Console.WriteLine(d);

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Hello " + name);

//int num1 = 70;
//int num2 = 10;
//Console.WriteLine(num1 + num2);
//Console.WriteLine(num1 - num2);
//Console.WriteLine(num1 * num2);
//Console.WriteLine(num1 / num2);

//Console.WriteLine("Enter your Age: ");
//string age = Console.ReadLine();

//Console.WriteLine("Enter your Country: ");
//string country = Console.ReadLine();

//int agenum = int.Parse(age);

//if (agenum >= 18 && country == "India")
//{
//    Console.WriteLine("Hello, you are eligible");
//}
//else
//{
//    Console.WriteLine("Sorry, you are not eligible");

//}


//Console.WriteLine(Math.Max(20, 29));
//Console.WriteLine(Math.Min(20, 29));
//Console.WriteLine(Math.Sqrt(25));
//Console.WriteLine(Math.Abs(-566));
//Console.WriteLine(Math.Round(89.30));


//string str1 = "Revolution";
//string str2 = "IT";
//Console.WriteLine(str1.Length);
//Console.WriteLine(str1 + " " + str2);

//int x = 30;
//int y = 90;
//Console.WriteLine(x < y);


//Session3-

//int ages = 19;
//if(ages > 21)
//{
//    Console.WriteLine("Valid");
//}
//else if(ages > 18)
//{
//    Console.WriteLine("Valid with conditions");
//}
//else
//{
//    Console.WriteLine("Invalid");
//}

//int day = 4;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("No Match");
//        break;
//}
//// Outputs "Thursday" (day 4)

//int i = 0;
//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int j = 6;
//do
//{
//    Console.WriteLine(j);
//}while (j <= 5);

//for(int x=0;x<=10;x++)
//{
//    Console.WriteLine(x);
//}

//for(int y=1;y<=12;y++)
//{
//    if(y==4)
//    {
//        break;
//    }
//    Console.WriteLine(y);
//}

//for (int z = 1; z <= 12; z++)
//{
//    if (z == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(z);
//}

//string[] cars = {"Suzuki","Hyundai","Tata","Audi"};
//Console.WriteLine(cars[0]);
//Console.WriteLine(cars.Length);
//Array.Sort(cars);
//foreach(string car in cars)
//{
//    Console.WriteLine(car);
//}

//int[] numArr = { 5, 1, 8, 9 };
//Console.WriteLine(numArr.Max());  // returns the largest value
//Console.WriteLine(numArr.Min());  // returns the smallest value
//Console.WriteLine(numArr.Sum());  // returns the sum of elements

//session4





using TrainingApp;
//object creation
Car car=new Car();
car.model="A5";
car.brand = "Audi";
car.year = "2024";
car.StartCar();

Car sportcar = new Car();
car.model = "Mustang";
car.brand = "Ford";
car.year = "2024";
car.StartCar();

Person person = new Person();
person.Name = "Mr. ABC";
Console.WriteLine(person.Name); 

Student student = new Student();
student.Name = "PQR";
Console.WriteLine(student.Name);

Operations operations = new Operations();
Console.WriteLine(operations.Addition(30,40));
Console.WriteLine(Math.Round(operations.Addition(30.90,78.90)));















