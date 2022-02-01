using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Bank
    {
        public List<SavingAccount>SavingAccounts = new List<SavingAccount>();
        public List<CurrentAccount> CurrentAccounts = new List<CurrentAccount>();
        public List<LoanAccount>LoanAccounts=new List<LoanAccount>();
        public SavingAccount savings=new SavingAccount();
        public CurrentAccount currentAcc=new CurrentAccount();
        public LoanAccount loan=new LoanAccount();
        public static int account_no = 1;
        public int GenerateAccount()
        {
            return account_no++;
        }
        public string CheckAccountType(string account_num)
        {
            int l = account_num.Length;
            if(account_num[l-1]=='0' && account_num[l-2]=='0' && account_num[l - 3] == '4')
            {
                return "loan";
            }
            else if (account_num[l - 1] == '0' && account_num[l - 2] == '0' && account_num[l - 3] == '3')
            {
                return "current";
            }
            else
            {
                return "save";
            }
        }
    }
}
