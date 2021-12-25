using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    public class User
    {
        public int UserID;
        public string UserName;
        public string Address;
        public double UserPay_Shirt;
        public double UserPay_Pant;
        public double UserPay_Bedsheet;
        public double UserPay_Suit;
        public double UserTotal_Pay;
        public List<Pant> pants= new List<Pant>();
        public List<Shirt> shirts=new List<Shirt>();
        public List<Suit> suits= new List<Suit>();
        public List<Bedsheet> bedSheets=new List<Bedsheet>();
       public User (int ID, string Name, string address)
        {
            this.UserID = ID;
            this.UserName = Name;
            this.Address = address;
        }
        public User()
        {

        }
    }
}
