using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IUT_Result_Processing_App
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {       
            using (var reader = new StreamReader(@"C:\Users\Hp\Downloads\SWE4201MarkSheet.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string ID = values[0];
                    string Name = values[1];
                    string Attendance =values[2].Trim();
                    string Quiz1 = values[3].Trim();
                    string Quiz2 = values[4].Trim();
                    string Quiz3 = values[5].Trim();
                    string Quiz4 = values[6].Trim();
                    string MID =  values[7].Trim();
                    string Final = values[8].Trim();
                    string Viva = values[9].Trim();
                    Student student = new Student(ID,Name, Attendance, Quiz1, Quiz2, Quiz3,Quiz4,MID, Final, Viva);
                    student.QuizTotal = student.BestQuizCalc(); 
                    student.averagePercentage = student.averagerPercentageCalc(student.Attendance, student.MID,student.QuizTotal , student.Final, student.Viva);
                    student.averagePercentage= Math.Round(student.averagePercentage, 2);
                    student.Grade = student.CalcGrade(student.averagePercentage);
                    student.Total = student.TotalNumber(student.Attendance, student.MID, student.QuizTotal, student.Final, student.Viva);
                    students.Add(student);
                    StudentList.Items.Add(student.ID + "\t"+ student.Name+"\t"+Convert.ToString(student.averagePercentage)+"\t"+ student.Grade);    
                    }
              
            }

        }
       

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string StudentID = Convert.ToString(SearchIDText.Text);
            var dumb = from Student1 in students 
                       where Student1.ID == StudentID 
                       select Student1;
            Student student = dumb.FirstOrDefault();
            ShowResultLabel.Text = "Attendance :" + "\t" + student.Attendance.ToString() + "\n" + "Quiz1 :" + "\t" + student.Quiz[0].ToString() + "\n" + "Quiz2 :" + "\t" + student.Quiz[1].ToString() + "\n" + "Quiz3:" + "\t" + student.Quiz[2].ToString() + "\n" + "Quiz4 :" + "\t" + student.Quiz[3].ToString() + "\n" + "Quiz (Best Three):" + "\t" + student.QuizTotal.ToString();
            ShowResult2.Text = "Mid :" + "\t" + student.MID.ToString() + "\n" + "Final :" + "\t" + student.Final.ToString() + "\n" + "Viva :" + "\t" + student.Viva.ToString() + "\n" + "Total :" + "\t" + student.Total.ToString() + "\n" + "Average Percentage :" + "\t" + student.averagePercentage.ToString() + "\n" + "Grade :" + "\t" + student.Grade.ToString() + "\n" + "Developed by ID: 200042163";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowResult2_Click(object sender, EventArgs e)
        {

        }
    }
        }
