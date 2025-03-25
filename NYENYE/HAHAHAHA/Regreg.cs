using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAHAHAHA
{
    internal class Regreg
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();

        static void Main()
        {
            Console.WriteLine("Welcome to the Registration System!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Show Registered Users");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    RegisterUser();
                }
                else if (choice == "2")
                {
                    ShowUsers();
                }
                else if (choice == "3")
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

        static void RegisterUser()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                Console.WriteLine("Username already taken. Try another one.");
                return;
            }

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            users.Add(username, password);
            Console.WriteLine("Registration successful!");
        }

        static void ShowUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users registered yet.");
                return;
            }

            Console.WriteLine("Registered Users:");
            foreach (var user in users.Keys)
            {
                Console.WriteLine($"- {user}");
            }
        }
    }

}
