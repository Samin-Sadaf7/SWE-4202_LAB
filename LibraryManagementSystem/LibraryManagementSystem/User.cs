using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class User
    {
        public int Userid;
        public string USerName;
        public string UserAddress;
        public List<int> books =new List<int>();
        public User()
        {

        }
        public User(int id,string Name, string Address)
        {
            this.Userid = id;
            this.USerName = Name;
            this.UserAddress = Address;

        }
        public void AddBook(int ID)
        {
            books.Add(ID);
        }
      }
}
