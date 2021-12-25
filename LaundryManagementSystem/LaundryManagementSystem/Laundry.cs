using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public  static class Laundry
    {    
         static public List<User>users = new List<User>();
         static public Shirt shirt = new Shirt();
         static public Pant pant = new Pant();
         static public Bedsheet Bedsheet = new Bedsheet();
         static public Suit suit = new Suit();
         static public void AddUser(User user)
        {
            users.Add(user);
        }
        static public bool order_shirt(int UserID, int quantity, int orderID, string shirt_TO_DO)
        {
            bool flag = false;
            foreach (User user in users)
            {
                if (user.UserID == UserID)
                {
                    shirt.shirtcalc(orderID, quantity, shirt_TO_DO, user);
                    user.shirts.Add(shirt);
                    flag = true;
                    break;
                }
            }   
            return flag;
        }
            static public bool order_pant(int UserID, int quantity, int orderID, string pant_TO_DO)
            {
                bool flag = false;
                foreach (User user in users)
                {
                        if (user.UserID == UserID)
                        {   
                            pant.pantcalc(orderID,quantity, pant_TO_DO, user);
                            user.pants.Add(pant);
                            flag = true;
                            break;
                        }
                }
                return flag;
        }
        static public bool order_bedsheet(int UserID, int quantity, int orderID, string shirt_TO_DO)
        {
            bool flag = false;
            foreach (User user in users)
            {
                    if (user.UserID == UserID)
                    {
                        Bedsheet.Bedsheetcalc(orderID, quantity, shirt_TO_DO, user);
                        user.bedSheets.Add(Bedsheet);
                        flag = true;
                        break;
                    }
            }
            return flag;
        }
        static public bool order_suit(int UserID, int quantity, int orderID, string suit_TO_DO)
        {
            bool flag = false;
            foreach (User user in users)
            {
                    if (user.UserID == UserID)
                    {
                        suit.suitcalc(orderID, quantity, suit_TO_DO, user);
                        user.suits.Add(suit);
                        flag = true;
                        break;
                    }
            }
            return flag;
        }
        static public bool OrderSituation(int orderid, string OrderStatus)
        {
            bool flag = false;
            foreach (User user in Laundry.users)
            {
                foreach (Shirt shirt in user.shirts)
                {
                    if (shirt.orderID == orderid)
                    {
                        flag = true;
                        shirt.Current_Stat = OrderStatus;
                        break;
                    }
                 }
                foreach (Pant pant in user.pants)
                {
                    if (pant.orderID == orderid)
                    {
                        flag = true;
                        pant.Current_Stat = OrderStatus;
                        break;
                    }
                }
                foreach (Bedsheet bedsheet in user.bedSheets)
                {
                    if (bedsheet.orderID == orderid)
                    {
                        flag = true;
                        bedsheet.Current_Stat = OrderStatus;
                        break;
                    }
                }
                foreach (Suit suit in user.suits)
                {
                    if (suit.orderID == orderid)
                    {
                        flag = true;
                        suit.Current_Stat = OrderStatus;
                        break;
                    }
                }
            }
            return flag;
        }
        static public double LaundrySubmitGetMoney(int orderID,string OrderStat,double current_account)
        {
            foreach (User user in Laundry.users)
            {
                foreach (Shirt shirt in user.shirts)
                {
                    if (shirt.orderID == orderID)
                    {
                        if (OrderStat == "Delivered")
                        {
                            current_account = current_account + user.UserTotal_Pay;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return current_account;
        }
        static public double LaundryCalcTotal(int UserID,double total_now)
        {
            foreach (User user in Laundry.users)
            {
                if (user.UserID == UserID)
                {
                    user.UserTotal_Pay = user.UserPay_Shirt + user.UserPay_Suit + user.UserPay_Pant + user.UserPay_Bedsheet;
                    total_now = user.UserTotal_Pay;
                    break;
                }

            }
            return total_now;

        }
    }
}
