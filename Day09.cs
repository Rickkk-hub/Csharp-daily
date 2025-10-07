//Day 9: Use else if. Grade checker (90+ = A, 80–89 = B, etc.).

using System;
using System.Collections.Generic;

 class Day09
{
    public static void Run()
    {
        Console.WriteLine("Enter your Grade");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 >= 100)
        {
            Console.WriteLine(num1 + " Your Grade is A");
        }

        else
        {
            Console.WriteLine(num1 + " Your Grade is B");
        }
    }
}
