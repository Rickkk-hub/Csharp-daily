//Ask for a string input for numbers 1 to 10 in words (e.g. one, two...) then output it's translation in tagalog
using System;
using System.Collections.Generic;



public class Day23
{
   public static void Main()
    {
        Dictionary<string, string> numbers = new Dictionary<string, string>()
        {
            {"one", "isa" },
            {"two", "dalawa" },
            {"three", "tatlo" },
            {"four", "apat" },
            {"five", "lima" },
            {"six", "anim" },
            {"seven", "pito" },
            {"eight", "walo" },
            {"nine", "siyam" },
            {"ten", "sampu" }


        };
        Console.WriteLine("input a numbers one to ten");
        string word = Console.ReadLine().ToLower();

        if (numbers.ContainsKey(word))
        {
        Console.WriteLine($"This translation of tagalog numbers: `{word}` is `{numbers[word]}`");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number one to ten");
        }
    }
}
