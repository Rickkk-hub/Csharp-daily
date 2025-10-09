//Day 12: Learn switch. Build a menu with 3 food choices.
using System;
using System.Collections.Generic;


class Day14
{
    public static void Run()
    {

        while (true)
        {
        

 Console.WriteLine("Enter lunch Time");
        int menu1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter 3 Food Choices");
        int menu2 = Convert.ToInt32(Console.ReadLine());

        switch (menu1)
        {
            case 1:
                Console.WriteLine("Umagahan");
                break;

            case 2:
                Console.WriteLine("Tang-halian");
                break;

            case 3:
                Console.WriteLine("Pang-gabi");
                break;
        }

        switch (menu2)
        {
            case 1:
                Console.WriteLine("You Choice: Adobo");
                break;

            case 2:
                Console.WriteLine("You Choice: Menudo");
                break;

            case 3:
                Console.WriteLine("You Choice: Tinola");
                break;

            default:
                Console.WriteLine("Invalid Food Choices");
                break;
        }

        Console.WriteLine("Please input try again? y/n");
        string again = Console.ReadLine().ToLower();
        
            if (again != "y") break;

        }   
     }
  }
  
