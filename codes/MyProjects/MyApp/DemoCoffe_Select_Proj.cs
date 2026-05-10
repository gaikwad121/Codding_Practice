
using System;

public class DemoCoffee
{
    public static void Demo()
    {
        ConsonentValueCount("hello");
        smallestNumFind();
        PalindromeNumber("madam");

        // -------- TARGET SECTION --------
        Console.WriteLine("Set your target!");
        int target;

        // Safe input
        while (!int.TryParse(Console.ReadLine(), out target))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        int start = 0;

        Console.WriteLine("Even numbers up to target:");
        while (start <= target)
        {
           // Console.WriteLine(start);
            start += 2;
        }

        // -------- COFFEE ORDER SECTION --------
        int totalCoffeeCost = 0;
        string continueOrder;

        do
        {
            Console.WriteLine("1. Small, 2. Medium, 3. Large");

            int userChoice;

            // Safe input
            while (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("Invalid choice. Enter 1, 2, or 3:");
            }

            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine($"Total coffee cost: {totalCoffeeCost}");
            Console.WriteLine("Do you want to continue ordering? (yes/no)");
            continueOrder = Console.ReadLine().ToLower();

        } while (continueOrder == "yes");

        Console.WriteLine($"Final bill: {totalCoffeeCost}");
    }

public static void targetAge()
{
    int targetAge=int.Parse(Console.ReadLine());
    int start=0;
        while (start <= targetAge)
        {
                Console.WriteLine(start + " ");

            start=start+2;
        }
}
public static void PalindromeNumber(string name)
    {
        
        string rev="";
        for(int i = name.Length - 1; i >= 0; i--)
        {
            rev=rev+name[i];
        }
        Console.WriteLine(rev);
        if (name.Equals(rev))
        {
            Console.WriteLine("its palindrome");
        }
        else
        {
            Console.WriteLine("It's not palindrome");
        }
    }


    public static void smallestNumFind()
    {
        int [] arr={2,3,4,5,6,7,8,9,10,11};
        int min=int.MaxValue;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min=arr[i];
            }
        }
            Console.WriteLine(min);
        }
    public static void ConsonentValueCount(string value)
    {
        int count=0;
        char [] ch=value.ToCharArray();
        for(int i = 0; i < ch.Length; i++)
        {
            if(ch[i]=='A' || ch[i]=='I' || ch[i]=='E' ||  ch[i]=='O' ||  ch[i]=='U' ||  ch[i]=='a' || ch[i]=='i' || ch[i]=='e' || ch[i]=='o' || ch[i]=='u' )
            {
              count++;  
            }
        }
            Console.WriteLine(count);
        }
    }
    

