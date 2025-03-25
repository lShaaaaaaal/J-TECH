using System;
using System.Collections.Generic;

namespace HAHAHAHA
{
    internal class Loglog
    {
        static void AppDomainSetup()
        {
            Console.WriteLine("Welcome!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Continue");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose to continue.");
                }
                else if (choice == "2")
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
    }
}
