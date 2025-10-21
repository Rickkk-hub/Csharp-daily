//output fibonacci sequence (base 1) on each keypress
using System;
using System.Collections.Generic;


class Day20
{
    public static void Run()
    {
        int a = 0;
        int b = 1;



        while (true)
        {
            Console.WriteLine("Press enter to continue");

            if (Console.ReadLine() == "")
            {
                Console.WriteLine("Fibonacci: ");
                Console.WriteLine(a);
             
            }
            int next = a + b;
            a = b;
            b = next;
        }
       
    }
}
