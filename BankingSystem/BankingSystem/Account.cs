using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    abstract public  class Account
    {
        public string Name;
        public string Account_Number;
        public double Balance;
        public string Date;
        public int transaction_num;
        public string TransactionTime;
        public List<string> transaction = new List<string>();
    }
}
