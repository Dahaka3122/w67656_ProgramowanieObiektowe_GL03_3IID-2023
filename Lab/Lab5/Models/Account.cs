using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public static class Account
    {
        private static List<Transaction> transactions = new List<Transaction>();

        public static decimal TotalIncome { get; set; }

        public static decimal TotalExpenses { get; set; }

        public static void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            transaction.ProcessTransaction();
        }

        public static void DisplaySummary()
        {
            Console.WriteLine($"Ogólna suma dochodów: {TotalIncome}");
            Console.WriteLine($"Ogólna suma wydatków: {TotalExpenses}");
        }
    }
}
