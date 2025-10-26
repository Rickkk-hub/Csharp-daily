//Ask for a number input, print an error when it's not a number using if else
using System;
using System.Collections.Generic;

class Day21
{
    public static void Run()
    {
         int num;


        Console.WriteLine("Enter the number");
        string input = Console.ReadLine();  

        

        if (int.TryParse(input, out num))
        {
           Console.WriteLine($"its is a number {num}");
        }
        else
        {
            Console.WriteLine("its is not a number");
        }
