// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.PortableExecutable;
namespace Demo;

public class practice
{
    public static void Main()
    {
        //Program to print numbers + check even/odd
checkEvenOdd(67);
NameCharLengthoddEven("Aaradhya");
Reverse("Gaikwad");
palidromeCheck("madam");
sumOfNumber(5);
LargestNumber();
countVowels("Hello");
    }
    static void checkEvenOdd(int num)
    {
        string result= num%2==0 ? "Even":"odd";
        Console.WriteLine("the number is  : " +result);

    }
    static void NameCharLengthoddEven(string num)
    {
        int lenth=num.Length;
        string result=lenth%2==0 ? "Even" : "Odd";
        Console.WriteLine("the name lenth is : " +result);
    }
    static void Reverse(string name)
    {

        string rev="";
      //  char []ch=name.ToCharArray();
        for(int i = name.Length-1; i >= 0; i--)
        {
             rev=rev+name[i];
        }
            Console.WriteLine(rev);
        }
        static void palidromeCheck(string name)
    {
        string rev="";
        for(int i = name.Length - 1; i >= 0; i--)
        {
            rev=rev+name[i];
        }
    
        if (name.Equals(rev))
        {
            Console.WriteLine("Palindrom string");
        }
        else
        {
           Console.WriteLine("Not Palindrom string");

        }
    }
        static void sumOfNumber(int num)
    {
        int sum=0;
        for(int i = 1; i <= num; i++)
        {
            sum=sum+i;
            
        }
        Console.WriteLine(sum);
        
    }
    static void PrintEven(int num)
    {
        for(int i = 1; i <= num; i++)
        {
            if (i % 2==0)
            {
                Console.WriteLine(i);
            }
            else
            {
                                Console.WriteLine(i);
            }
        }
    }
    static void LargestNumber()
    {
        int max=0;
        int [] arr={2, 8, 5, 10, 3};
        for(int i = 0; i < arr.Length; i++)
        {
           
                if (arr[i] > max)
                {
                    max=arr[i];
                }
            }
                Console.WriteLine("Largest Number is : "+max);
            }        
    static void countVowels(string name)
    {
        int count=0;
    for(int i = 0; i <name.Length; i++)
        {
            char ch=Char.ToLower(name[i]);
            if (ch=='a'|| ch=='i' || ch=='o' || ch=='u' || ch=='e')
            {
                count++;
            }
        }
            Console.WriteLine(count);
        }
        }
    
    
    
