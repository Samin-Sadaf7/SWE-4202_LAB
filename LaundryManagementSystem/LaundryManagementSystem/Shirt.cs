using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public class Shirt:Order
    {
        public int shirts_wash = 15;
        public int shirts_iron = 7;
        public double shirtcalc(int orderID, int quantity, string shirt, User user)
        {
            double shirts;
            this.orderID = orderID;
            this.quantity = quantity;
            this.Status = shirt;
            if (shirt == "Wash")
            {
                user.UserPay_Shirt = quantity * shirts_wash;
                shirts = quantity * shirts_wash;

            }
            else if (shirt == "Iron")
            {
                user.UserPay_Shirt = quantity* shirts_iron;
                shirts = quantity * shirts_iron;
            }
            else
            {
                user.UserPay_Shirt = quantity * (shirts_iron + shirts_wash);
                shirts = quantity * (shirts_iron + shirts_wash);
            }
            return shirts;
        }
        public string Shirt_List(Shirt shirt)
        {
            return "Shirt " + "\t" + shirt.quantity.ToString() + "\t" + shirt.Status.ToString() + "\t";
        }
        public Shirt()
        {

        }
    }
}
