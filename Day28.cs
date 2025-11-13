// Create a function square(x) that returns the square of the number

using System;


class Day28
{

    public static int Square(int x)
    {
        return x * x;
    }
    public static void Run()
    {
        Console.WriteLine("Enter the 1st number");
        int x = Convert.ToInt32(Console.ReadLine());

        int result = Square(x);

        Console.WriteLine($"the square of the number {x} is {result}");
    }
}
