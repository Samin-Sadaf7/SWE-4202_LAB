using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public int BookID;
        public string BookName;
        public string Publisher;
        public string Author;
        public int  Quantity;
        public Book()
        {

        }
        public Book(int ID, string Name, string publisher, string author, int quantity)
        {   
            this.BookID = ID;
            this.BookName = Name;
            this.Publisher = publisher;
            this.Author = author;
            this.Quantity = quantity;
        }
        public string history()
        {
            string name= this.BookID.ToString()+' '+this.BookName;
            return name;
        }
    }
}
