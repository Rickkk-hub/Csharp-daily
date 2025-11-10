//Create functions: subtract(x,y), divide(x,y), Multiplication(x,y)
using System;
using System.Runtime.InteropServices;


class Day26
{

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    
    public static int Multiplication(int x, int y)
    {
        return x * y;
    }
    public static void Run()
    {
        Console.WriteLine("Enter the 1st number");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number");
        int y = Convert.ToInt32(Console.ReadLine());

        int add = Add(x, y);
        int subtract = Subtract(x, y);
        int multiplication = Multiplication(x, y);


        Console.WriteLine($"Addtion: {add}");
        Console.WriteLine($"Subtract: {subtract}");
        Console.WriteLine($"Multiplication: {multiplication}");

    }
}
