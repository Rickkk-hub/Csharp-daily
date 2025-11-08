//(formerly day18) print out unique characters and their count on a string
using System;
using System.Collections.Generic;
using System.Linq;

public class Day24
{

    public static void Run()
    {

        Dictionary<char, int> count = new Dictionary<char, int>();

        Console.WriteLine("Enter your name");
        string name = Console.ReadLine() ?? "";

        string Unique = new string(name.Distinct().ToArray());

        foreach (char c in Unique)
            if (count.ContainsKey(c))
            {
                count[c]++;
            }
            else
            {
                count[c] = 1;
            }

        Console.WriteLine("This unique characters and their count on string! ");

        foreach (var item in count)
         Console.WriteLine($"this count: {item.Key} = {item.Value} ");

      
         int sum = 0;
        foreach (var item in count)

        sum += item.Value;

        Console.WriteLine($"Total characters: {sum}");
        Console.WriteLine();

    }

}
