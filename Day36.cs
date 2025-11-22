//output remaining seconds on the current day
using System;

namespace practicecsharp
{
    class Day36
    {
        public static void Seconds()
        {
            DateTime second = DateTime.Now;


            Console.WriteLine(("Seconds: ") + second.ToString("ss"));
        }
        public static void Run()
        {

            Seconds();

        }
    }
}
