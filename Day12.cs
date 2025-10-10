using System;
using System.Text;
using System.Security.Cryptography;



class Day11
{
    public static void Run()
    {
        Console.WriteLine("Username");
        string Username = Console.ReadLine();

        Console.WriteLine("Password");
        string Password = Console.ReadLine();

        string hashed = HashPassword(Password);


        Console.WriteLine("Username: " + Username);
        Console.WriteLine("Password: " + hashed);
    }
    static string HashPassword(string password)
    {
        using SHA256 sha256 = SHA256.Create();
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x1"));
            }
            return sb.ToString();
        }
    }
}
