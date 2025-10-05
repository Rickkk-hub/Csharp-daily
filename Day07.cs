//Day 8: Learn if statement. Check if number is positive or negative.

using System;

class Day07
{
    public static void Run()
    {
        Console.WriteLine("Enter your number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 > 0)
        {
            Console.WriteLine("It's positive: " + num1);
        }

        else if (num1 < 0)
        {
            Console.WriteLine("It's negative");
        }
        else
        {
        Console.WriteLine("Its is zero");
       }

    }
}
