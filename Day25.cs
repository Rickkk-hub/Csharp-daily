//Create function: add(x,y) that returns the sum of 2 numbers

using System;

class Day25
{

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static void Run()
    {
        Console.WriteLine("Enter the 1st number");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number");
        int y = Convert.ToInt32(Console.ReadLine());

        int sum = Add(x, y);
       
       Console.WriteLine($"Total: {sum}");
    }
}
