//Day 11: Practice logical operators (&&, ||). Login system with username + password.
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

class Day13

{
    public static void Run()
    {
        while (true)
        {

            string UsernameCorrect = "ricky";
            string PasswordCorrect = "admin123";
            string hashed = ComputeSha256Hash(PasswordCorrect);



            Console.WriteLine("Username:");
            string Username = Console.ReadLine();

            Console.WriteLine("Password:");
            string Password = Console.ReadLine();

            Console.WriteLine(hashed + PasswordCorrect);
        

            if (Username == UsernameCorrect && Password == PasswordCorrect)
            {
                Console.WriteLine("login Successfull");
                Console.WriteLine("MyAccount: " + "U:" + UsernameCorrect + " " + "P:" + hashed);
                break;
            }
            else if (Username == UsernameCorrect && Password != PasswordCorrect)
            {
                Console.WriteLine("Please Enter the Correct Password");

            }
            else if (Username != UsernameCorrect)
            {
                Console.WriteLine("Enter the Correct Username");
            }
            else
            {
                Console.WriteLine("Login Failed.");
            }

            static string ComputeSha256Hash(string PasswordCorrect)
            {
                using (SHA256 Sha256Hash = SHA256.Create())
                {
                    // Compute hash as byte array
                    byte[] bytes = Sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(PasswordCorrect));

                    // Convert bytes to hex string
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                        builder.Append(b.ToString("x2"));

                    return builder.ToString();
                }
            }
        }
    }
}
