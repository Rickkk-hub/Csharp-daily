// Day 2: Print your name, age, using Console.WriteLine().
using System;

class Day02

{
    public static void Run()
    {
        {
          //this for name
            Console.WriteLine("Enter your Name: ");
            String name = Console.ReadLine();

          //this for age
            Console.WriteLine("Enter your Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
 
          //this for print 
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Your age is: " + Age);
     
        }
    }
}
