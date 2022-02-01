using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class LoanAccount : Account
    {
        public LoanAccount(string name, string account_num, double currentBalance, string Date)
        {
            this.Name = name;
            this.Account_Number = account_num;
            this.Balance = currentBalance;
            this.Date = Date;
        }
        public LoanAccount()
        {

        }
    }
}
