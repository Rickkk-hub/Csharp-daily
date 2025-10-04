//Day 5: Get user input using Console.ReadLine(). Ask name & greet them.
using System;

class Day05
{
    public static void Run()
    {
        Console.WriteLine("Enter your FirstName");
        String name1 = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter your LastName");
        String name2 = Convert.ToString(Console.ReadLine());

        Console.WriteLine(name1 + " " + name2);

 
    }
}
