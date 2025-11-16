// print out current date; then print out current time; using 2 separate function call, but outputting on the same line
using System;

class Day32
{
    public static void Date()
    {
        DateTime date = DateTime.Now;

        Console.WriteLine(("The Current Date: ") + date.ToString("MMMM-dd-yyyy"));
    }

    public static void Time() 
    {
        DateTime time = DateTime.Now;
        
        Console.Write(("The Current Time: ") + time.ToString("h:mm tt"));
    }

    public static void Run()
    {
        Date();  
        Time();
     
    }
}
