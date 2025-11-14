// Create a function roll() that generates 2 numbers between 1 to 6
using System;

class Day30
{
    public static void Roll()
    { 

        Random random = new Random();

        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);


        Console.WriteLine($"You Rolled: {dice1}, {dice2}");
    }
    

    public static void Run()
    {
        Roll();
    }
}
