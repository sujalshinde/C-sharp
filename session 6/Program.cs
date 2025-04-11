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





using System.Collections;
using TrainingApp;
using static TrainingApp.Operations;

//object creation
//Car car=new Car();
//car.model="A5";
//car.brand = "Audi";
//car.year = "2024";
//car.StartCar();

//Car sportcar = new Car();
//car.model = "Mustang";
//car.brand = "Ford";
//car.year = "2024";
//car.StartCar();

//Person person = new Person();
//person.Name = "Mr. ABC";
//Console.WriteLine(person.Name); 

//Student student = new Student();
//student.Name = "PQR";
//Console.WriteLine(student.Name);

//Operations operations = new Operations();
//Console.WriteLine(operations.Addition(30,40));
//Console.WriteLine(Math.Round(operations.Addition(30.90,78.90)));

//session 5

Truck truck = new Truck();
truck.Brand = "Ashok L" ;
truck.Model = "6000";
Console.WriteLine(truck.Brand + " " + truck.Model);
truck.StartVehicle();

Animal animal = new Animal();
animal.AnimalSound();

Tiger tiger = new Tiger();
tiger.AnimalSound();

Dog dog = new Dog();
dog.AnimalSound();

SalesStaff salesStaff = new SalesStaff();
salesStaff.StaffJoining();
salesStaff.LeaveApplication();


Country country = new Country();
country.AddCountry();
country.RemoveCountry();

Level level = Level.Medium;
Console.WriteLine(level);
Console.WriteLine((int)level);

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
Console.WriteLine(readText); // Output the content

try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//session6
int i = 1;
object o = i; // boxing  
int j = (int)o; // unboxing  



bool result = Operations.AreEqual<double>(3.89,6.78);
Console.WriteLine(result);  

ArrayList al = new ArrayList();
al.Add("Test");
al.Add(90);
al.Add(DateTime.Parse("24-12-2024"));
foreach(object item in al)
{
    Console.WriteLine(item);
}

List<int> lst = new List<int>();
lst.Add(100);
lst.Add(200);
lst.Add(300);
lst.Add(400);
foreach (int listitem in lst)
{
    Console.WriteLine(listitem);

}

//delegate
HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
del("Testing");

var course = "testing";
Console.WriteLine(course);

var marks = 900;
Console.WriteLine(marks);

dynamic dvar1 = "dynamci var";
dynamic dvar2 = 89;
Console.WriteLine(dvar1);
Console.WriteLine(dvar2);

//var var3 = "testing var";
//var3 = 76;

dynamic testd;
testd = 8999;












