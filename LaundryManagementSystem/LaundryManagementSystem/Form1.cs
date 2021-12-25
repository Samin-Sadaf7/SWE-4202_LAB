using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class LMS_form : Form
    {
        public int prev_order = 0;
        public double current_account = 0;
        public LMS_form()
        {
            InitializeComponent();
        }
 
        private void AddAccount_Click(object sender, EventArgs e)
        {
            int UserID= Convert.ToInt32(AccountUserIDTXT.Text);
            string name=UsernameTXT.Text;
            string address=AddressTXT.Text;
            User user=new User(UserID,name,address);
            Laundry.AddUser(user);
            MessageBox.Show("The User has been added");
        }

        private void Place_Order_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(OrderUserIDtxt.Text);
            int pant_number = Convert.ToInt32(PantsQuantityTXT.Text);
            int shirt_number = Convert.ToInt32(ShirtsQuantityTXT.Text);
            int bedsheets_number = Convert.ToInt32(BedSheetsQuantityTXT.Text);
            int suits_number = Convert.ToInt32(SuitsQuantityTXT.Text);
            int orderID = prev_order;
            prev_order++;
            double total_now = 0;
            if (Laundry.order_shirt(UserID, shirt_number, orderID, Shirts_ToDO.Text) && Laundry.order_pant(UserID, pant_number, orderID, Pants_To_Do.Text) && Laundry.order_bedsheet(UserID, bedsheets_number, orderID, BedSheetToDo.Text) && Laundry.order_suit(UserID, suits_number, orderID, SuitsToDo.Text))
            {
              total_now= Laundry.LaundryCalcTotal(UserID,total_now); 
              MessageBox.Show("Your order is " + orderID.ToString() + " " + "Please pay $  " + total_now.ToString());
            }
            else
            {
                MessageBox.Show("Please create account first");
            }
        }
        private void SubmitStatusButton_Click(object sender, EventArgs e)
        {
            int orderid = Convert.ToInt32(OrderIDTXT.Text);
            if(Laundry.OrderSituation(orderid, OrderStatus.Text))
            {
                current_account=Laundry.LaundrySubmitGetMoney(orderid, OrderStatus.Text, current_account);
                CurrentBalanceLabel.Text ="Current Balance: " + current_account.ToString();
                MessageBox.Show("Order Status has been updated");
            }
            else
            {   
                CurrentBalanceLabel.Text="Current Balance:"+current_account.ToString();
                MessageBox.Show("Invalid OrderID");
            }
        }

        private void OrderListAndStatusShow_Click(object sender, EventArgs e)
        {
            int orderID=Convert.ToInt32(ShowOrderIDTXT.Text);
            bool flag = false;
            foreach (User user in Laundry.users)
            {
                ShowList.Items.Clear();
                ShowList.Items.Add("Dress" + "\t" + "Quantity" + "\t" + "To_Do" + "\t" + "Amount");
                foreach (Shirt shirt in user.shirts)
                {
                    if (shirt.orderID == orderID)
                    {
                        flag = true;
                        StatusLabel.Text = "Order Situation  "+shirt.Current_Stat.ToString();
                        AmountLabel.Text = "Amount  "+user.UserTotal_Pay.ToString();
                        NameOfUserLabel.Text="UserName:  "+user.UserName.ToString();
                        AddressLabel.Text="Address  "+user.Address.ToString();
                        ShowList.Items.Add(shirt.Shirt_List(shirt) + user.UserPay_Shirt.ToString());
                        break;
                    }
                }
                foreach (Pant pant in user.pants)
                {
                    if (pant.orderID == orderID)
                    {
                        ShowList.Items.Add(pant.Pant_List(pant) + user.UserPay_Pant.ToString());
                        break;
                    }
                }
                foreach (Bedsheet bedsheet in user.bedSheets)
                {
                    if (bedsheet.orderID == orderID)
                    {
                        ShowList.Items.Add(bedsheet.Bedsheet_List(bedsheet) + user.UserPay_Bedsheet.ToString());
                        break;
                    }
                }
               foreach (Suit suit in user.suits)
                {
                    if (suit.orderID == orderID)
                    {
                        ShowList.Items.Add(suit.Suit_List(suit) + user.UserPay_Suit.ToString());
                        break;
                    }

                }
            }
             if (flag == false)
            {
               MessageBox.Show("Invalid Id");
            }
        }
    }
}
