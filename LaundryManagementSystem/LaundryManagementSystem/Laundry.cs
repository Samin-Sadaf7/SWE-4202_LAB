using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public  class Laundry
    {
         public List<User> users = new List<User>();
         public Shirt shirt = new Shirt();
         public Pant pant = new Pant();
         public Bedsheet Bedsheet = new Bedsheet();
         public Suit suit = new Suit();
         public User User = new User();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        static public int prev_order = 0;
        public bool order_shirt(int UserID, int quantity, int orderID, string shirt_TO_DO)
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
         public bool order_pant(int UserID, int quantity, int orderID, string pant_TO_DO)
        {
            bool flag = false;
            foreach (User user in users)
            {
                if (user.UserID == UserID)
                {
                    pant.pantcalc(orderID, quantity, pant_TO_DO, user);
                    user.pants.Add(pant);
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public bool order_bedsheet(int UserID, int quantity, int orderID, string shirt_TO_DO)
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
        public bool order_suit(int UserID, int quantity, int orderID, string suit_TO_DO)
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
        public void OrderSituation(int orderid, string OrderStatus)
        {
            foreach (User user in users)
            {
                foreach (Shirt shirt in user.shirts)
                {
                    if (shirt.orderID == orderid)
                    {
                        shirt.Current_Stat = OrderStatus;
                        break;
                    }
                }
                foreach (Pant pant in user.pants)
                {
                    if (pant.orderID == orderid)
                    {
                        pant.Current_Stat = OrderStatus;
                        break;
                    }
                }
                foreach (Bedsheet bedsheet in user.bedSheets)
                {
                    if (bedsheet.orderID == orderid)
                    {
                        bedsheet.Current_Stat = OrderStatus;
                        break;
                    }
                }
                foreach (Suit suit in user.suits)
                {
                    if (suit.orderID == orderid)
                    { 
                        suit.Current_Stat = OrderStatus;
                        break;
                    }
                }
            }
        }
           
        public void LaundryCalcTotal(int UserID)
        {
            foreach (User user in users)
            {
                if (user.UserID == UserID)
                {
                    user.UserTotal_Pay = user.UserPay_Shirt + user.UserPay_Suit + user.UserPay_Pant + user.UserPay_Bedsheet;
                    break;
                }

            }
        }
        static public int GenerateOrderID()
        {
            return prev_order++;
        }
    }
}