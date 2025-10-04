//Day 6: Combine variables and input. Ask for name + age → print in a sentence.
using System;

class Day06
{
    public static void Run()
    {
        Console.WriteLine("Enter your name");
        String name = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
       

       Console.WriteLine("My name is " + name + " and my age is " + age);
     
  }
}
