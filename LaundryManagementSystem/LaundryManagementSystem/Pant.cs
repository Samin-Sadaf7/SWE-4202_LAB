using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public class Pant : Order  
    {
        public int pants_wash=10;
        public int pants_iron=5;  
        public double pantcalc(int orderID, int quantity, string pant,User user)
        {
            double pants;
            this.orderID = orderID;
            this.quantity = quantity;
            this.Status = pant;
            if (pant == "Wash")
            {
              user.UserPay_Pant = quantity * pants_wash;
              pants = quantity * pants_wash;
            }
            else if (pant == "Iron")
            {
             user.UserPay_Pant = quantity * pants_iron;
             pants = quantity * pants_iron;
            }
            else
            {
              user.UserPay_Pant = quantity * (pants_iron + pants_wash);
              pants = quantity * (pants_iron + pants_wash);
            }
              
            return pants;
        }
        public Pant()
        {

        }
        public string Pant_List(Pant pant)
        {
            return "Pant " + "\t" + pant.quantity.ToString() + "\t" + pant.Status.ToString() + "\t";
        }
    }
}
