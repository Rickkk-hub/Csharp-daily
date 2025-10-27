// Ask for a number input, throw an error if it's more than 100 or less than zero
using System;

class Day22
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");

    
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (num < 0)
            {
                Console.WriteLine("You entered below zero!");
            }
            else if (num > 100)
            {
                Console.WriteLine("You entered more than 100!");
            }
            else
            {
                Console.WriteLine($"entered number: {num}");
            }
        }// if you try the Parse method u need to set a conditions
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
