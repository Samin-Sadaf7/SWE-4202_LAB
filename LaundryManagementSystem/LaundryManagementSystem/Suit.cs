using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public class Suit:Order
    {
        public int suits_wash = 25;
        public int suits_iron = 20;
        public double suitcalc(int orderID, int quantity, string suit,User user)
        {
            double suits;
            this.orderID = orderID; 
            this.quantity = quantity;
            this.Status = suit;
            if (suit == "Wash")
            {
              user.UserPay_Suit = quantity * suits_wash;
              suits = quantity * suits_wash;
            }
            else if (suit == "Iron")
            {
              user.UserPay_Suit = quantity * suits_iron;
              suits = quantity * suits_iron;
            }
            else
            { 
             user.UserPay_Suit = quantity * (suits_iron + suits_wash);
             suits = quantity * (suits_iron + suits_wash);
            }
            return suits;
        }
        public Suit()
        {

        }
        public string Suit_List(Suit suit)
        {
            return "Suit" + "\t" + suit.quantity.ToString() + "\t" + suit.Status.ToString() + "\t";
        }
    }
}
