//Create a simple login and using Max Attemps security.
using System;
using System.Collections.Generic;

// im using the syntax of while loop for looping a username and password for the attemps

class Day15
{
    public static void Run()

    {   // this my out
        string Realuser = "rick";
        string RealPass = "12345";
        
        // this my input for max attemp
        string username, password;
        int Attemps = 0;
        const int MaxAttemps = 3;

        while (Attemps < MaxAttemps)
        {
            
        Console.WriteLine("Enter your username");
        username = Console.ReadLine();

        Console.WriteLine("Enter your password");
        password = Console.ReadLine();

        if (username == Realuser && password == RealPass)
        {
            Console.WriteLine("Login Successfull");
            break;
        }
        else
        { ++Attemps; 
            Console.WriteLine("Attemps: " + Attemps + " of " + MaxAttemps);
        }

            if (Attemps == MaxAttemps)
            {
                Console.WriteLine("Max Attemps is Used: Please Try again next life");
            }
      }
   }
}

