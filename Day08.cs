//Day 9: Use if/else. Check if a person is old enough to vote (18+).
using System;
using System.Collections.Generic;



class Day08

{
    public static void Run()
    {
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
 
        if (age >= 18)
        {
            Console.WriteLine(age + " You are legal age");
        }
        else
        {
            Console.WriteLine(age + " You are under age" );
        }
    }
}

