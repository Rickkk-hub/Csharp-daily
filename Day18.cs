//Ask for a input, print out the unique characters on that input
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;



class Day18
{
    public static void Run()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        string uniqueName = new string(name.Distinct().ToArray());


        Console.WriteLine($"Hello! " + uniqueName);
    }
}
