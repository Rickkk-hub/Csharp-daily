//print out unique characters from a string using built-in array-unique function or it's equivalent
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;



class Day17
{
    public static void Run()
    {
        string name = "Ricky Picardal";


        string unique = new string(name.Distinct().ToArray());


        Console.WriteLine("Original: " + "Hello World! " + name);
        Console.WriteLine("Unique: " + "Hello World! " + unique);
    }
}
