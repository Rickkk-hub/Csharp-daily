//print array, and then push a new item using array push or equivalent.
using System;
using System.Collections.Generic;
using System.Linq;


class Day16
{
    public static void Run()
    {
        var Iphone = new List<string> { "Iphone14", "Iphone15", "Iphone16" };
        Console.WriteLine("Old items: " + string.Join(",", Iphone));
        Console.WriteLine("");

        
        Console.WriteLine("Updated List:");
        Iphone.Add($"New! Iphone17");

        foreach (var NewIphone in Iphone)
        {
            Console.WriteLine("Items: " + NewIphone);
        }
    }
}
