using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Transactions
    {
        public int checking { get; set; }
        public int savings { get; set; }



    }

    class Program
    {
        static void Main(string[] args)
        {

            var account = new List<Transactions>();
            {
                account.Add(new Transactions()

                {

                    checking = 500,
                    savings = 500,

                });
            };


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------WELCOME TO FIRST BANK OF SUNCOAST--------");
            Console.WriteLine();
            Console.WriteLine();

            var quitApplication = false;
            while (quitApplication == false)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdrawal");
                Console.WriteLine("Check Balance");
                Console.WriteLine("Quit");
                Console.WriteLine();
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "Deposit")
                {
                    Console.WriteLine("Would you like to deposit into checking or savings?");
                    Console.Write("Choice: ");
                    var depositChoice = Console.ReadLine();
                    if (depositChoice == "checking")
                    {
                        var foundChecking = account.Select(account => account);
                        Console.Write("Amount:");
                        var depositAmount = int.Parse(Console.ReadLine());
                        var newDeposit = account.Sum(account => account.checking + depositAmount);

                    }
                    if (choice == "Withdrawal")
                    {
                        Console.WriteLine("Would you like to withdraw from checking or savings");
                        Console.Write("Choice: ");
                    }
                    if (choice == "Check Balance")
                    {


                        Console.WriteLine("Which would you like to see, checking or savings?");
                        Console.Write("Choice: ");
                        var balanceChoice = Console.ReadLine();
                        if (balanceChoice == "checking")
                        {
                            var checkingBalance = account.Max(account => account.checking);
                            Console.WriteLine($"Your checking account's balance is ${checkingBalance}.");
                        }
                        if (balanceChoice == "savings")
                        {
                            var savingsBalance = account.Max(account => account.savings);
                            Console.WriteLine($"Your savings account's balance is ${savingsBalance}.");
                        }
                    }
                    if (choice == "Quit")
                    {
                        quitApplication = true;
                    }
                }
                Console.WriteLine("--------THANK YOU FOR BANKING WITH FBoSC--------");
            }
        }

