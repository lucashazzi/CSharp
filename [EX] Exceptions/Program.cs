using System;
using System.Globalization;
using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result;
                double result2;
                bool valid = false;
                Account acc = new Account();
                while (!valid)
                {
                    Console.WriteLine("Hello and welcome to the Eurotopian Banks, please insert your name: ");
                    acc.Holder = Console.ReadLine();

                    Console.WriteLine("Now insert your account number, please: ");

                    if (int.TryParse(Console.ReadLine(), out result))
                        acc.Number = result;
                    else
                    {
                        Console.WriteLine("Insert only numbers please.");
                        continue;
                    }

                    Console.WriteLine("Insert your desired withdraw limit: ");
                    if (double.TryParse(Console.ReadLine(), out result2))
                        acc.WithdrawLimit = result2;
                    else
                    {
                        Console.WriteLine("Insert only numbers please.");
                        continue;
                    }
                    acc.Balance = 0;
                    valid = true;
                }

                while (true)
                {
                    Console.WriteLine("Select an option: ");
                    Console.WriteLine("-DEPOSIT: \"D\"");
                    Console.WriteLine("-WITHDRAW: \"W\"");
                    Console.WriteLine("-CHECK BALANCE: \"BL\"");
                    Console.WriteLine("-CHANGE WITHDRAW LIMIT: \"WL\"");
                    
                    string option = Console.ReadLine().ToLower();

                    if (option == "d")
                    {
                        Console.Write("Amount: ");
                        if (double.TryParse(Console.ReadLine(), out result2))
                        {
                            acc.Deposit(result2);
                        }
                        else
                        {
                            Console.WriteLine("The amount is invalid.");
                            continue;
                        }
                    }
                    else if(option == "wl")
                    {
                        Console.Write("Withdraw Limit amount: ");
                        if (double.TryParse(Console.ReadLine(), out result2))
                        {
                            acc.WithdrawLimit = result2;
                        }
                        else
                        {
                            Console.WriteLine("The amount is invalid.");
                            continue;
                        }
                    }
                    else if(option == "w")
                    {
                        Console.Write("Withdraw amount: ");
                        if (double.TryParse(Console.ReadLine(), out result2))
                        {
                            acc.Withdraw(result2);
                            Console.WriteLine($"New Balance: ${acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                        else
                        {
                            Console.WriteLine("The amount is invalid.");
                            continue;
                        }
                    }
                    else if(option == "bl")
                    {
                        Console.WriteLine($"Actual Balance: ${acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                        continue;
                    }
                }
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
