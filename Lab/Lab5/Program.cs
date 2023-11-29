using System;
using Lab5.Models;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Square square = new Square(4);

            Console.WriteLine("Pole okręgu: " + circle.CalculateArea());
            Console.WriteLine("Pole kwadratu: " + square.CalculateArea());


            Account.AddTransaction(new IncomeTransaction { Amount = 100, TransactionDate = DateTime.Now });
            Account.AddTransaction(new ExpenseTransaction { Amount = 50, TransactionDate = DateTime.Now });
            Account.AddTransaction(new IncomeTransaction { Amount = 200, TransactionDate = DateTime.Now });

            Account.DisplaySummary();

        }
    }
}
