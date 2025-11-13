// Create a function greatest(x,y,z) that returns which of the 3 given numbers are greater (using > or < signs)

using System;


class Day29
{
    public static int Greatest(int x, int y, int z)
    {
        if (x > y && x > z)

            return x;

        else if (y > x && y > z)
        {
            return y;
        }
        else
        {
            return z;
        }
    }


    public static void Run()
    {
        Console.WriteLine("Enter the 1st number");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 1st number");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 1st number");
        int z = Convert.ToInt32(Console.ReadLine());

        int result = Greatest(x, y, z);
    

     Console.WriteLine($"the number are greater than {x}, {y}, {z}, is the ({result})");
    }
}
