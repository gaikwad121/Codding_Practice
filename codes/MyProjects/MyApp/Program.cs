// See https://aka.ms/new-console-template for more information
using System;

public class practice
{
    public static void d()
    {
        //Sum of even numbers
evenSum();
    oddSum();
 revNumber();
 PalindromeNumber("demo");
 

    }
     //Sum of even numbers
     public static void evenSum()
    {
        int sum=0;
        int num=100;
        for(int i = 0; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                sum+=i;
            }
        }
Console.WriteLine(sum);
    }
    //Odd of even numbers
    public static void oddSum()
    {
        int Sum=0;
        int num=300;
        for(int i = 0; i <= num; i++)
        {
            if (i % 2 != 0)
            {
                Sum+=i;
            }
        }
            Console.WriteLine(Sum);
        }
        //Reverse number
public static void revNumber()
    {
        int num=897654;
        int rev=0;
        while (num>0)
        {
            rev=rev*10+num%10;
            num=num/10;

        }
        Console.WriteLine(rev);
    }
    public static void PalindromeNumber(string name)
    {
        
        string rev="";
        for(int i = name.Length - 1; i >= 0; i--)
        {
            rev=rev+name[i];
        }
        Console.WriteLine(rev);
    }
    
    }

