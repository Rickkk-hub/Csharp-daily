//output a number, and wait for a keypress, then increment the number and print it out, then repeat
using System;
using System.Collections.Generic;


class Day19
{
    public static void Run()
    {
        int number = 0;
      

        while (true)
        {
            
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(num + number);
            }
            else
            {
                ++number;
                Console.WriteLine($"Result: {num + number}");
            }

            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
     }
   }
 }
