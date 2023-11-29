using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public abstract class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public abstract void ProcessTransaction();
    }
}
