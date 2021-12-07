using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem__2._0_
{
    internal class ResearchArticle: Book
    {
        public string DOI;
        public string published_date;
        public string Conference_Journal;
        public ResearchArticle(int ID,string Author, string Title, string Publisher, int Quantity, string DOI, string Published_Date, string C_F)
        {
            this.id = ID;
            this.Title = Title;
            this.Publisher = Publisher;
            this.Quantity = Quantity;
            this.DOI = DOI;
            this.Author = Author;
            this.published_date = Published_Date;
            this.Conference_Journal = C_F;
       }  
        public ResearchArticle()
        {

        }
        public string Getinfo()
        {
          return Convert.ToString(id) +' ' + Title +' '+ Author+ ' ' + DOI + ' ' + Convert.ToString(Quantity) + ' ' + Conference_Journal;
        }
    }
  
}
