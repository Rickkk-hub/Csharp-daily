// print out current date/time
using System;


class Day31
{
    public static void Datetime()
    {
        DateTime dateTime = DateTime.Now;

        Console.WriteLine($"The time and date is: {dateTime}");
    }


    public static void Run()
    {
        Datetime();
    }
}
