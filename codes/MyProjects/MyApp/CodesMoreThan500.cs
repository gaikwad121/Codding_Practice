using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace codes;

public class CodesMoreThan500
{
    static void Main()
    {
        storeNameAsString();
        Console.WriteLine(Yourage(23));
        Console.WriteLine(salaryEmp(125000.00));
        Console.WriteLine(Gender('F'));
        Console.WriteLine("is eligible for vote " + validForVote(24));
        printVariables();
        Console.WriteLine(AddTowInt(56, 32));
        Console.WriteLine(multipleNum(98, 45));
        Console.WriteLine(diveInt(99, 11));
        Console.WriteLine(devNum(9.92m, 98.2m));
        Console.WriteLine(remainder(89.00m, 43.00m));
        Console.WriteLine(convValue(2));
        intConve(98);
        chvalue();
        intValue();
        mobNumber();
        thirdVariable(98, 23);
        withoutThirdvarible(91, 23);
    }
    //Swap without third variable
    private static void withoutThirdvarible(int a, int b)
    {
        Console.WriteLine(" a : " + a + " " + " b : " + b);

        a = a * b;
        b = a / b;
        a = a / b;
        Console.WriteLine(" a : " + a + " " + " b : " + b);

    }
    //Swap two variables using third variable
    private static void thirdVariable(int a, int b)
    {
        Console.WriteLine(" a : " + a + " " + " b : " + b);

        int temp = 0;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine(" a : " + a + " " + " b : " + b);

    }
    //Store mobile number
    private static void mobNumber()
    {
        double Num = 1234567890;
        Console.WriteLine(Num);
    }
    //Convert ASCII to char
    private static void intValue()
    {
        int c = 98;
        Console.WriteLine((char)c);
    }
    //Print ASCII value of char
    private static void chvalue()
    {
        char c = 'B';
        Console.WriteLine((int)c);
    }
    //Convert double to int
    private static void intConve(double d)
    {
        int c = Convert.ToInt32(d);
        Console.WriteLine(c);
    }
    //Convert int to double
    private static double convValue(int c)
    {
        double d = c;
        return d;
    }
    //Find remainder
    private static decimal remainder(decimal a, decimal b)
    {
        decimal rem = a / b;
        return rem;
    }
    //Divide decimal numbers
    private static decimal devNum(decimal a, decimal b)
    {
        return a / b;
    }
    //Divide two integers
    private static int diveInt(int a, int b)
    {
        return a / b;

    }
    //Multiply two numbers
    private static double multipleNum(int a, int b)
    {
        return a * b;
    }

    //Store your name in string
    private static void storeNameAsString()
    {
        string Name = "jyoti";
        Console.WriteLine(Name);
    }
    // tore your age in int
    private static int Yourage(int age)
    {
        return age;
    }
    //print salary
    private static double salaryEmp(double salary)
    {
        return salary;
    }
    //print gender in char
    private static char Gender(char gender)
    {
        return gender;
    }
    //Store true/false in bool validate vote elligiblity
    private static bool validForVote(int age)
    {
        bool result = (age % 2 == 0) ? true : false;
        return result;

    }
    // Add two integers
    private static double AddTowInt(int a, int b)
    {
        return a + b;

    }
    //Print all variables
    private static void printVariables()
    {
        bool salary = int.TryParse("98.9k", out int b);// it only helpfull handle a compile time error during giving wrong value of salary
        string name = "jyoti";
        char ch = 'F';
        Console.WriteLine($"salary : {b} + name {name}  + ch {ch}");
    }
}
