using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem__2._0_
{
    internal class StudyBook:Book
    {
        public string ISBN;
        public string Genre;
        public StudyBook(int ID, string Author, string Title, string Publisher, int Quantity,string ISBN, string Genre)
        {
            this.id = ID;
            this.Author = Author;   
            this.Title = Title; 
            this.Publisher = Publisher; 
            this.Quantity = Quantity;
            this.ISBN = ISBN;
            this.Genre = Genre;
        }
        public StudyBook()
        {

        }
        public string GetInfo()
        {
            return Convert.ToString(id) + ' ' + Title + ' ' + Author + ' ' + ISBN + ' ' + Convert.ToString(Quantity);
        }
    }
}
