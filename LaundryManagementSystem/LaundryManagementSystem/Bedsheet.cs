using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public class Bedsheet:Order
    {
        public int bedsheets_wash = 20;
        public int bedsheets_iron = 15;
        public double Bedsheetcalc(int orderID,int quantity, string bedsheet, User user)
        {
            double bedsheets;
            this.orderID = orderID;
            this.quantity = quantity;
            this.Status = bedsheet;
            if (bedsheet == "Wash")
            {
              user.UserPay_Bedsheet = quantity * bedsheets_wash;
              bedsheets = quantity * bedsheets_wash;
            }
            else if (bedsheet == "Iron")
            {
             user.UserPay_Bedsheet = quantity * bedsheets_iron;
             bedsheets = quantity * bedsheets_iron;
             }
            else
            {           
                user.UserPay_Bedsheet = quantity * (bedsheets_iron + bedsheets_wash);
                bedsheets = quantity * (bedsheets_iron + bedsheets_wash);
            }
            return bedsheets;
        }
        public Bedsheet()
        {

        }
        public string Bedsheet_List(Bedsheet bedsheet)
        {
            return "BedSheet " + bedsheet.quantity.ToString() + "\t" + bedsheet.Status.ToString() + "\t";
        }
    }
}
