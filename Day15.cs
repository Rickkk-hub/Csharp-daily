//print a defined array, then remove the last item using array pop or equivalent

using System;
using System.Collections.Generic;
using System.Linq;


class Day15
{
    public static void Run()
    {
        var Phone = new List<string>{"Samsung", "Iphone", "Infinix", "Poco"};

        string LastPhone = Phone[Phone.Count - 4];
        Phone.RemoveAt(Phone.Count - 4);
        
        Console.WriteLine($"Removed: {LastPhone}");
        Console.WriteLine("Remaining Phones: " + string.Join(", ", Phone));
    }
}
