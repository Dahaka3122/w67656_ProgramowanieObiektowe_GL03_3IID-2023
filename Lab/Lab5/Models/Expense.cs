using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public class ExpenseTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.TotalExpenses += Amount;
        }
    }
}
