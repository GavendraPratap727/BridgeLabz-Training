using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class Bank
    {
        static Dictionary<int, double> accounts = new Dictionary<int, double>();

        // Withdrawal requests (account numbers)
        static Queue<int> withdrawalQueue = new Queue<int>();

        static void Main()
        {
            Console.Write("Enter number of accounts: ");
            int n = int.Parse(Console.ReadLine());

            // Add accounts
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter account number: ");
                int accNo = int.Parse(Console.ReadLine());

                Console.Write("Enter balance: ");
                double balance = double.Parse(Console.ReadLine());

                if (!accounts.ContainsKey(accNo))
                {
                    accounts[accNo] = balance;
                }
                else
                {
                    Console.WriteLine("Duplicate account ignored.");
                }
                Console.WriteLine();
            }

            // Withdrawal requests
            Console.Write("Enter number of withdrawal requests: ");
            int w = int.Parse(Console.ReadLine());

            for (int i = 0; i < w; i++)
            {
                Console.Write("Enter account number for withdrawal: ");
                withdrawalQueue.Enqueue(int.Parse(Console.ReadLine()));
            }

            // Process withdrawals
            ProcessWithdrawals();

            // Display sorted customers by balance
            DisplaySortedByBalance();
        }

        static void ProcessWithdrawals()
        {
            Console.WriteLine("\nProcessing Withdrawals:");

            while (withdrawalQueue.Count > 0)
            {
                int accNo = withdrawalQueue.Dequeue();

                if (accounts.ContainsKey(accNo))
                {
                    Console.Write("Enter withdrawal amount for account " + accNo + ": ");
                    double amount = double.Parse(Console.ReadLine());

                    if (accounts[accNo] >= amount)
                    {
                        accounts[accNo] -= amount;
                        Console.WriteLine("Withdrawal successful. New Balance: " + accounts[accNo]);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance for account " + accNo);
                    }
                }
                else
                {
                    Console.WriteLine("Account not found: " + accNo);
                }
                Console.WriteLine();
            }
        }

        static void DisplaySortedByBalance()
        {
            // Balance -> List of account numbers
            SortedDictionary<double, List<int>> sorted =
                new SortedDictionary<double, List<int>>();

            foreach (var acc in accounts)
            {
                if (!sorted.ContainsKey(acc.Value))
                    sorted[acc.Value] = new List<int>();

                sorted[acc.Value].Add(acc.Key);
            }

            Console.WriteLine("Customers Sorted by Balance:");
            foreach (var entry in sorted)
            {
                foreach (int accNo in entry.Value)
                {
                    Console.WriteLine("Account: " + accNo + " | Balance: " + entry.Key);
                }
            }
        }
    }
}
