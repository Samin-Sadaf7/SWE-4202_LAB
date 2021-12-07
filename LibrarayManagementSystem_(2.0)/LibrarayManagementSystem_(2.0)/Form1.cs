using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarayManagementSystem__2._0_
{
    public partial class LMS : Form
    {
        List<ResearchArticle>researchArticles = new List<ResearchArticle>();
        List<StudyBook>studyBooks=new List<StudyBook>();
        public LMS()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void AddStudyBookButton_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(StudyIDtxt.Text);
            string title = StudyTitleTXT.Text;
            string author=StudyAuthorTXT.Text;
            string publisher=StudyPublisherTxt.Text;
            string ISBN= ISBNtxt.Text;
            string genre=GenreTXT.Text;
            int quantity = Convert.ToInt32(StudyQuantityTXT.Text);
            StudyBook book = new StudyBook(id, author, title, publisher, quantity, ISBN, genre);
            MessageBox.Show("Study Book Added Successfully");
            studyBooks.Add(book);

        }

        private void AddResearchArticleButton_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(ResearchIDtxt.Text);
            string title = ResearchTitle.Text;
            string author = ResearchAuthorTxt.Text;
            string publisher = ResearchPublisherTXT.Text;
            string DOI = DOItxt.Text;
            string publishedDate=PublishDateTXT.Text;
            string ConferenceJournal = ConferJornalText.Text;
            int quantity= Convert.ToInt32(ResearchQuantityTXT.Text);
            ResearchArticle book = new ResearchArticle(id, author, title, publisher, quantity, DOI, publishedDate, ConferenceJournal);
            MessageBox.Show("Research Article Added Successfully");
            researchArticles.Add(book);
        }

        private void BorrowStudyBookButton_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(StudyBorrowIDtxt.Text);
            bool flag = false;
            foreach(StudyBook bookItem in studyBooks)
            {
                if (id == bookItem.id)
                {
                    flag = true;
                    bookItem.Quantity -= 1;
                    MessageBox.Show("The book has been borrowed successfully");
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("The book is not available");
            }
        }

        private void ReserchBorrowbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ResearchBorrowTXT.Text);
            bool flag = false;
            foreach (ResearchArticle book in researchArticles)
            {
                if (id == book.id)
                {
                    flag = true;
                    book.Quantity -= 1;
                    MessageBox.Show("The book has been borrowed successfully");
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("The book is not available");
            }
        }

        private void ShowStudyBookButton_Click(object sender, EventArgs e)
        {
            StudyBookList.Items.Clear();
            foreach(StudyBook book in studyBooks)
            {
                StudyBookList.Items.Add(book.GetInfo());
            }
        }

        private void ShowArticleButton_Click(object sender, EventArgs e)
        {
            ResearchArticleList.Items.Clear();
            foreach(ResearchArticle book in researchArticles)
            {
                ResearchArticleList.Items.Add(book.Getinfo());
            }
        }

        private void Conference_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

