using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public class IncomeTransaction : Transaction
    {
        public override void ProcessTransaction()
        {
            Account.TotalIncome += Amount;
        }
    }
}
