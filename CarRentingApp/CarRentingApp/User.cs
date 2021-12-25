using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingApp
{
    internal class User
    {
        public int id;
        public string name;
        public string address;
        public string destination;
        public string rentedcar;
        public User(int id, string name,string address ,string destination)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.destination = destination;
        }
    }
}
