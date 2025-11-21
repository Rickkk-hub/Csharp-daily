//ask for a year input and output if it's a leap year or not using built in functions if possible
using System;


namespace practicecsharp
{
  class Day35
    {
        public static void Run()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());


            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} Its a leap year");
            }
            else
            {
                Console.WriteLine($"{year} Its not a leap year");
            }
        }
    }
}
