using System;
using System.Collections.Generic;
using System.Globalization;

class ATM
{
    static decimal balance = 1000.00m; // starting balance
    static List<string> history = new List<string>();

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        history.Add($"Account opened with starting balance: {balance.ToString("C", CultureInfo.CurrentCulture)}");

        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    Deposit();
                    break;
                case "3":
                    Withdraw();
                    break;
                case "4":
                    PrintHistory();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
             Console.ReadLine();
    // 👇 Safe clear (won’t crash even in VS Code or Visual Studio Debug Console)
    try
    {
        Console.Clear();
    }
    catch (IOException)
    {
        // ignore — environment doesn’t support clearing
    }
}
    }

    static void ShowMenu()
    {
        Console.WriteLine("======== SIMPLE ATM ========");
        Console.WriteLine("1. Check balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Transaction history");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option (1-5): ");
    }

    static void CheckBalance()
    {
        Console.WriteLine($"\nCurrent balance: {balance.ToString("C", CultureInfo.CurrentCulture)}");
    }

    static void Deposit()
    {
        decimal amount = ReadPositiveDecimal("Enter deposit amount: ");
        if (amount <= 0) return;

        balance += amount;
        string record = $"{DateTime.Now}: Deposited {amount.ToString("C", CultureInfo.CurrentCulture)} — New balance {balance.ToString("C", CultureInfo.CurrentCulture)}";
        history.Add(record);
        Console.WriteLine("Deposit successful.");
        Console.WriteLine(record);
    }

    static void Withdraw()
    {
        decimal amount = ReadPositiveDecimal("Enter withdrawal amount: ");
        if (amount <= 0) return;

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal cancelled.");
            return;
        }

        balance -= amount;
        string record = $"{DateTime.Now}: Withdrew {amount.ToString("C", CultureInfo.CurrentCulture)} — New balance {balance.ToString("C", CultureInfo.CurrentCulture)}";
        history.Add(record);
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine(record);
    }

    static void PrintHistory()
    {
        Console.WriteLine("\n--- Transaction History ---");
        if (history.Count == 0)
        {
            Console.WriteLine("No transactions yet.");
            return;
        }

        for (int i = 0; i < history.Count; i++)
        {
            Console.WriteLine($"{i+1}. {history[i]}");
        }
    }

    static decimal ReadPositiveDecimal(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine()?.Trim();

        if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal value))
        {
            Console.WriteLine("Invalid number. Operation cancelled.");
            return 0m;
        }

        if (value <= 0)
        {
            Console.WriteLine("Amount must be greater than zero. Operation cancelled.");
            return 0m;
        }

        return Math.Round(value, 2); // round to cents
    }
}
