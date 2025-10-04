// Day 4: Do math with operators (+, -, *, /, %). Make a calculator with 2 numbers.
using System;


class Day04
{
    public static void Run()
    {

        Console.WriteLine("Enter the First number");
        int num1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter the Second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

       Console.Write("Enter operator (+, -, /, *): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine(num1 + num2);
                break;

            case '-':
                Console.WriteLine(num1 - num2);
                break;

            case '/':
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Invalid Numbers");
                break;
        }
    }
}
