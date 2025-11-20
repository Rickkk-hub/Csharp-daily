//print out the current date time but with the specific format: Mon Jan 13 2025 14:54:30 

using System;


class Day34
{
    public static void Date()
    {
        DateTime datetime = DateTime.Now;

        Console.WriteLine(datetime.ToString("ddd MMMM yyyy h:mm tt"));
    }

    public static void Run()
    {
        Date();
    }
}
