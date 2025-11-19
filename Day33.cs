// print out current unix timestamp in seconds and milliseconds using built in functions if available
using System;

class Day33
{
    public static void Run()
    {
        long unixSeconds = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        long unixMilliseconds = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        Console.WriteLine("Unix Seconds: " + unixSeconds);
        Console.WriteLine("Unix Milliseconds: " + unixMilliseconds);
    }
}
