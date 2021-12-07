using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibraryManagementSystem : Form
    {   
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        private bool  userExists(int id)
        {
            foreach (User user in users)
            {
                if (user.Userid == id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool bookExists(int id)
        {
            foreach (Book book in books) {
                if (book.BookID == id)
                {
                    return true;
                }
            }
            return false;
        }
        public LibraryManagementSystem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ADDuser_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(UserIDTXT.Text);
            string address = AddressTXT.Text;
            string name = UserNameTXT.Text;
            User user = new User(id,name,address);
            users.Add(user);
            MessageBox.Show("Added Successfully");
        }

        private void ADDbook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDTXT.Text);
            string name = BookNAmeTXT.Text;
            string author= AuthorTXT.Text;
            string publisher= PublisherTXT.Text;
            int quantity = Convert.ToInt32(QuantityTXT.Text);
            if (quantity < 0)
            {
                MessageBox.Show("Invalid Quantity");
                return;
            }
            Book book = new Book(id, name ,publisher, author,quantity);
            books.Add(book);
            MessageBox.Show("Book Added Successfully");
        }

        private void Borrowbook_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(BorrowUSERtxt.Text);
            int bookid = Convert.ToInt32(BorrowBookTXT.Text);
            if(bookExists(bookid) && userExists(userid))
            {   
                foreach(Book book in books)
                {
                    if (book.BookID == bookid)
                    {
                        if (book.Quantity < 1)
                        {
                            MessageBox.Show("Not enough book to borrow");
                            break;
                        }
                        book.Quantity = book.Quantity - 1;
                        foreach (User user in users)
                        {
                            user.books.Add(bookid);
                            MessageBox.Show("Book has been added successfully");
                        }
                        break;
                    }
                }
              }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        private void ShowUSer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ShowUSerTXT.Text);
            User user = new User();
            bool flag = false;
            foreach (User user1 in users)
            {
                if (user1.Userid == id)
                {
                    flag = true;
                    user = user1;
                    break;

                }
            }
            if (flag == false)
            {
                MessageBox.Show("User could not be found");
            }
            UserList.Items.Clear();
            for (int i = 0; i < user.books.Count; i++)
             {   
                 int id_book = user.books[i];
                 for (int j=0;j<books.Count; j++) {
                     if (books[j].BookID == id_book)
                     {
                         UserList.Items.Add(books[j].history());
                     }
                         }   
             }
           
        
        }

        private void ShowBook_Click(object sender, EventArgs e)
        {
            bool flag=false;
            int id=Convert.ToInt32(ShowBOOKtxt.Text);
            foreach (Book book in books)
            {   if (id == book.BookID)
                {   flag = true;
                    BookIDLabel.Text = "ID:" + ' ' + book.BookID.ToString();
                    BookTitleLabel.Text = "Title:" + ' ' + book.BookName;
                    BookPublisherLabel.Text = "Publisher:" + ' ' + book.Publisher;
                    BookAuthorLabel.Text = "Author:" + ' ' + book.Author;
                    BookQuantityLabel.Text ="Quantity:"+' '+book.Quantity.ToString();
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Book could not find");
            }
  
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void QuantityTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowBOOKinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
