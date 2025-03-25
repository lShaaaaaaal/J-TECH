using System;
using System.Collections.Generic;

class Register
{
    static Dictionary<string, string> users = new Dictionary<string, string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the System!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Continue Without Registration");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Show Registered Users");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine()?.Trim();

            if (choice == "1")
            {
                Console.WriteLine("You chose to continue without registration.");
            }
            else if (choice == "2")
            {
                RegisterUser();
            }
            else if (choice == "3")
            {
                ShowUsers();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting... Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    private static void ShowUsers()
    {
        throw new NotImplementedException();
    }

    static void RegisterUser()
    {
        Console.Write("Enter a username: ");
        string username = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(username)) ;
    }
}

