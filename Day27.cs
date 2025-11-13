//Create a function that will subtract x from y, but only until zero
using System;

    class Day27
    {
        public static int Subtract(int x, int y)
        {
          
            return x - y;
        }

        public static void Run()
        {
            Console.WriteLine("Enter the 1st number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());

            int subtract = Subtract(x, y);

            Console.WriteLine($"{x} Subtract to {y} result is {subtract}" );
        }
    }
