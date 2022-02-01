using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Banking_System : Form
    {
        public Banking_System()
        {
            InitializeComponent();
        }
        Bank bank=new Bank();
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string acc_name = Account_NameTXT.Text;
            double acc_balance=Convert.ToDouble(AmountTXT.Text);
            string date = CreatedDate.Text;
            string acc_num_init = Convert.ToString(bank.GenerateAccount());
            if(AccountTypeCombo.Text=="Saving Account")
            {
                string account_num = acc_num_init + 314;
                if (acc_balance >= 50000)
                {
                    bank.savings = new SavingAccount(acc_name, account_num, acc_balance, date);
                    bank.SavingAccounts.Add(bank.savings);
                    MessageBox.Show("Saving Account has been created successfully: Your Account Number is:" + account_num);
                }
                
                else
                {
                    MessageBox.Show("Can not be Created");
                }

            }
            else if(AccountTypeCombo.Text=="Current Account")
            {
                if (acc_balance < 500)
                {
                    MessageBox.Show("You can not create the account");
                }
                else
                {
                    string account_num = acc_num_init + 300;
                    bank.currentAcc = new CurrentAccount(acc_name, account_num, acc_balance, date);
                    bank.CurrentAccounts.Add(bank.currentAcc);
                    MessageBox.Show("Current Account has been created successfully: Your Account Number is:" + account_num);
                }
                }
            else
            {
                string account_num = acc_num_init + 400;
                acc_balance = acc_balance + (acc_balance * 9) / 100;
                bank.loan=new LoanAccount(acc_name,account_num,acc_balance, date);
                bank.LoanAccounts.Add(bank.loan);
                MessageBox.Show("Loan Account has been created successfully: Your Account Number is:" + account_num);
            }
        
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            string type = bank.CheckAccountType(WithdrawAccountNumTXT.Text);
            if (type == "current")
            {
                foreach(Account Account in bank.CurrentAccounts)
                {
                    if (Account.Account_Number == WithdrawAccountNumTXT.Text)
                    {
                        try
                        {
                            double r = Convert.ToDouble(WithdrawAmountTXT.Text);
                            double p = Account.Balance - Convert.ToDouble(WithdrawAmountTXT.Text);
                            if (p < 0 || r < 0)
                            {
                                throw new System.Exception();
                            }
                            else
                            {
                                Account.Balance = Account.Balance - Convert.ToDouble(WithdrawAmountTXT.Text);
                                Account.transaction.Add("Withdrawed Amount" + "\t" + WithdrawAmountTXT.Text + "\t on" + WithdrawDate.Text);
                                Account.transaction_num++;
                                MessageBox.Show("Withdraw Successful");
                                break;
                            }
                        }
                        catch (System.Exception){
                            MessageBox.Show("You Can not Withdraw");
                        }
                        
                    }
                }
            }
            else if (type == "save")
            {
                foreach (SavingAccount Account in bank.SavingAccounts)
                {
                    if (Account.Account_Number == WithdrawAccountNumTXT.Text)
                    {
                        try
                        {
                            bool flag = false;
                            double r = Convert.ToDouble(WithdrawAmountTXT.Text);
                            double p = Account.Balance - Convert.ToDouble(WithdrawAmountTXT.Text);
                            if (!Account.TransactionTime.ContainsKey(WithdrawDate.Text))
                            {
                                Account.TransactionTime.Add(WithdrawDate.Text, 1);
    
                            }
                            else
                            {
                                if (Account.TransactionTime[WithdrawDate.Text] >= 5)
                                {
                                    flag = true;
                                }
                                else
                                {
                                    Account.TransactionTime[WithdrawDate.Text]++;
                                }

                            }
                            if (p < 0 || r < 0 || flag)
                            {
                                throw new System.Exception();
                            }
                            else
                            {   
                                Account.Balance = Account.Balance-15- Convert.ToDouble(WithdrawAmountTXT.Text);
                                Account.transaction_num++;
                                Account.transaction.Add("Withdrawed Amount" + "\t" + WithdrawAmountTXT.Text + "\t on" + WithdrawDate.Text);
                                MessageBox.Show("Withdraw Successful");
                                break;
                            }
                        }
                        catch (System.Exception)
                        {
                            MessageBox.Show("You Can not Withdraw");
                        }
                    }
                }

            }
            else
            {

                MessageBox.Show("You can not Withdraw");

            }
        }

        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            string type = bank.CheckAccountType(DepositAccountNumTXT.Text);
            if (type == "loan")
            {
                foreach(LoanAccount Account in bank.LoanAccounts)
                {
                    if(Account.Account_Number==DepositAccountNumTXT.Text)
                    try
                    {
                        double r = Convert.ToDouble(DepositAmountTXT.Text);
                        double p = Account.Balance - Convert.ToDouble(DepositAmountTXT.Text);
                        if (p <= 0 || r < 0)
                        {
                            throw new System.Exception();
                        }
                        else
                        {
                            Account.Balance = Account.Balance - Convert.ToDouble(DepositAmountTXT.Text);
                            Account.transaction.Add("Depostied Amount" + "\t" + DepositAmountTXT.Text + "\t on" + DepositDate.Text);
                             Account.transaction_num++;
                            MessageBox.Show("Deposit Successful");
                            break;
                        }
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("You Can not Deposit");
                    }
  
                }
            }
            else if (type == "save")
            {
                foreach (SavingAccount Account in bank.SavingAccounts)
                {
                    if (Account.Account_Number == DepositAccountNumTXT.Text)
                    {
                        try
                        {
                            double r = Convert.ToDouble(DepositAmountTXT.Text);
                            double p = Account.Balance + Convert.ToDouble(DepositAmountTXT.Text);
                            bool flag = false;
                            if (!Account.TransactionTime.ContainsKey(DepositDate.Text))
                            {
                                Account.TransactionTime.Add(DepositDate.Text, 1);

                            }
                            else
                            {
                                if (Account.TransactionTime[DepositDate.Text] >= 5)
                                {
                                    flag = true;
                                }
                                else
                                {
                                    Account.TransactionTime[DepositDate.Text]++;
                                }
                               
                            }
                            if (r < 0 || flag)
                            {
                                throw new System.Exception();
                            }
                            else
                            {
                                Account.Balance = Account.Balance - Convert.ToDouble(DepositAmountTXT.Text);
                                Account.transaction.Add("Depostied Amount" + "\t" + DepositAmountTXT.Text + "\t on" + DepositDate.Text);
                                Account.transaction_num++;
                                MessageBox.Show("Deposit Successful");
                                break;
                            }
                        }
                        catch (System.Exception)
                        {
                            MessageBox.Show("You Can not Deposit");
                        }
                    }
                }
                }
             else{
                    foreach (CurrentAccount Account in bank.CurrentAccounts)
                    {
                    if (Account.Account_Number == DepositAccountNumTXT.Text)
                    {
                        try
                        {
                            double r = Convert.ToDouble(DepositAmountTXT.Text);
                            double p = Account.Balance + Convert.ToDouble(DepositAmountTXT.Text);
                            if (r < 0)
                            {
                                throw new System.Exception();
                            }
                            else
                            {
                                Account.Balance = Account.Balance - Convert.ToDouble(DepositAmountTXT.Text);
                                Account.transaction.Add("Depostied Amount" + "\t" + DepositAmountTXT.Text + "\t on" + DepositDate.Text);
                                Account.transaction_num++;
                                MessageBox.Show("Deposit Successful");
                                break;
                            }
                        }
                        catch (System.Exception)
                        {
                            MessageBox.Show("You Can not Deposit");
                        }
                    }
                }
                }
            }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string account_num = ShowAccountNum.Text;
            string type = bank.CheckAccountType(account_num);
            if(type== "save")
            {
                bool flag = false;
                TransactionList.Items.Clear();
                foreach(SavingAccount Account in bank.SavingAccounts)
                {   
                    if (Account.Account_Number == account_num)
                    {
                        flag = true;
                        TransactionList.Items.Add(Convert.ToString(Account.transaction_num) + "\r\n");
                        foreach (string ts in Account.transaction)
                        {
                            TransactionList.Items.Add(ts);
                        }
                        AccountInfoLabel.Text = "Name\t:" + Account.Name + "\r\n" + "Date:\t" + Account.Date + "\r\n" + "Balance:" + Convert.ToString(Account.Balance);
                        break;

                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Couldnot Find");
                }
            }
            else if (type == "loan")
            {
                bool flag = false;
                TransactionList.Items.Clear();
                foreach (LoanAccount Account in bank.LoanAccounts)
                {
                    if (Account.Account_Number == account_num)
                    {
                        flag = true;
                        TransactionList.Items.Add(Convert.ToString(Account.transaction_num) + "\r\n");
                        foreach (string ts in Account.transaction)
                        {
                            TransactionList.Items.Add(ts);
                        }
                        AccountInfoLabel.Text = "Name\t:" + Account.Name + "\r\n" + "Date:\t" + Account.Date + "\r\n" + "Balance:" + Convert.ToString(Account.Balance);
                        break;

                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Couldnot Find");
                }
            }
            else
            {
                    bool flag = false;
                    TransactionList.Items.Clear();
                    foreach (CurrentAccount Account in bank.CurrentAccounts)
                    {
                        if (Account.Account_Number == account_num)
                        {
                            flag= true;
                            TransactionList.Items.Add(Convert.ToString(Account.transaction_num) + "\r\n");
                            foreach (string ts in Account.transaction)
                            {
                            TransactionList.Items.Add(ts);
                            }
                        AccountInfoLabel.Text = "Name\t:" + Account.Name + "\r\n" + "Date:\t" + Account.Date + "\r\n" + "Balance:" + Convert.ToString(Account.Balance);
                            break;

                        }
                    }
                if (!flag)
                {
                    MessageBox.Show("Couldnot Find");
                }

            }
        }
    }
}
