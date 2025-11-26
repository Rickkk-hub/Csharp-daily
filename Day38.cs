
using System;

namespace practicecsharp
{
    class Day38
    {

        static string storedEmail = "";
        static string storedPass = "";

        public static void Run()

        {

            while (true)
            {
                Console.WriteLine("\n---Menu---");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. exit");


                int choice = int.Parse(Console.ReadLine() ?? "");

                switch (choice)
                {
                    case 1:
                        Register();
                        break;

                    case 2:
                        Login();
                        break;

                    case 3:
                        Console.WriteLine("Exit Successful");
                        return;

                    default:
                        Console.WriteLine("input invalid, Please try again.");
                        return;
                }
            }
        }

        public static void Register()
        {
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine() ?? "";

            Console.WriteLine("Enter the password");
            string password = Console.ReadLine() ?? "";

            Console.WriteLine("Enter the confirm password");
            string conpassword = Console.ReadLine() ?? "";

            if(!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Invalid email format!");
                return;
            }

            if (email == storedEmail)
            {
                Console.WriteLine("Email is already taken!");
                return;
               
            }

            if (password == conpassword)
            {
                storedEmail = email;
                storedPass = password;

                Console.WriteLine("Registration Successful");
            }
            else
            {
                Console.WriteLine("Password do not match!");
               
            }
        }

        public static void Login()
        {
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine() ?? "";

            Console.WriteLine("Enter the password");
            string password = Console.ReadLine() ?? "";

            if (storedPass == password && storedEmail == email)
            {
                Console.WriteLine("Login Successful");

            }
            else
            {
                Console.WriteLine("Invalid Email or Password");
            }
        }
    }
}
