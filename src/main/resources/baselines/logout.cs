using System;
using System.Collections.Generic;

namespace LoginFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Login System\n");

            // Sample users for demonstration purposes
            Dictionary<string, string> users = new Dictionary<string, string>
            {
                { "admin", "password123" },
                { "user1", "mypassword" },
                { "guest", "guestpass" }
            };

            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = ReadPassword();

                if (Authenticate(username, password, users))
                {
                    Console.WriteLine("\nLogin successful. Welcome, " + username + "!");
                    isLoggedIn = true;

                    bool isRunning = true;
                    while (isRunning)
                    {
                        Console.WriteLine("\nOptions:");
                        Console.WriteLine("1. Logout");
                        Console.WriteLine("2. Exit");

                        Console.Write("Select an option: ");
                        string option = Console.ReadLine();

                        switch (option)
                        {
                            case "1":
                                Console.WriteLine("\nYou have been logged out.\n");
                                isRunning = false;
                                isLoggedIn = false;
                                break;
                            case "2":
                                Console.WriteLine("\nGoodbye!");
                                return;
                            default:
                                Console.WriteLine("\nInvalid option. Please try again.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid username or password. Please try again.\n");
                }
            }
        }

        static bool Authenticate(string username, string password, Dictionary<string, string> users)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        static string ReadPassword()
        {
            string password = string.Empty;
            ConsoleKey key;

            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password[0..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }
    }
}
