using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    internal class Medicine
    {
        public string name;
        public string company;
        public int stock;
        public double price;
        public int serial;
        public Medicine(string name, string company, int stock, double price,int serial)
        {
            this.name = name;
            this.company = company;
            this.stock = stock;
            this.price = price;
            this.serial = serial;
        }
        public Medicine()
        {

        }
    }
}
