// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//implicit type casting
int a = 9;
double b = a;
Console.WriteLine(a);
Console.WriteLine(b);

//explicit type casting
double c = 78.90;
int d = (int)c;
Console.WriteLine(d);

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Hello " +name);

int num1 = 70;
int num2 = 10;
Console.WriteLine(num1+num2);
Console.WriteLine(num1-num2);
Console.WriteLine(num1*num2);
Console.WriteLine(num1/num2);

Console.WriteLine("Enter your Age: ");
string age = Console.ReadLine();

Console.WriteLine("Enter your Country: ");
string country = Console.ReadLine();

int agenum = int.Parse(age);

if(agenum>=18 && country == "India")
{
Console.WriteLine("Hello, you are eligible");
}
else
{
    Console.WriteLine("Sorry, you are not eligible");

}


Console.WriteLine(Math.Max(20, 29));
Console.WriteLine(Math.Min(20, 29));
Console.WriteLine(Math.Sqrt(25));
Console.WriteLine(Math.Abs(-566));
Console.WriteLine(Math.Round(89.30));


string str1 = "Revolution";
string str2 = "IT";
Console.WriteLine(str1.Length);
Console.WriteLine(str1+" "+str2);

int x = 30;
int y = 90;
Console.WriteLine(x<y);










