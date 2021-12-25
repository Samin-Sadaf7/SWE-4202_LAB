using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradesApp
{
    public partial class GradesApp : Form
    {
        public GradesApp()
        {
            InitializeComponent();
        }



        private void Calculate_Click_1(object sender, EventArgs e)
        {
            double attend = Convert.ToDouble(AttendanceTXT.Text);
            attend = (attend / 28) * 30;
            double without_remainder_attend=Math.Truncate(attend);
            double remainder_attend=attend- without_remainder_attend;
            if(remainder_attend >= 0.5)
            {
                attend = attend + 1;
            }
            AttendanceRes.Text = attend.ToString("#")+"/30";
            double  MID= Convert.ToDouble(Midtxt.Text);
            double Final= Convert.ToDouble(FinalTXT.Text); 
            MidRes.Text= MID.ToString()+ "/75";
            FinalRes.Text = Final.ToString()+ "/150";
            double[] quiz=new double[4];
            quiz[0]=Convert.ToDouble(Quiz1TXT.Text);
            quiz[1]=Convert.ToDouble(Quiz2txt.Text);
            quiz[2] = Convert.ToDouble(Quiz3txt.Text);
            quiz[3]=Convert.ToDouble(Quiz4txt.Text);
            Array.Sort(quiz);
            double quizresult = quiz[1] + quiz[2] + quiz[3];
            QuizRes.Text = quizresult.ToString()+"/45";
            double attendance = Convert.ToDouble(AttendanceTXT.Text);
            double TOTAL= attendance+MID+Final+quizresult;
            TotalRes.Text = TOTAL.ToString() + "/300";
            double result = (TOTAL / 300) * 100;
            if (result >= 80 && result<=100)
            {
                GradeRes.Text = "A+";
            }
            else if(result <80 && result >=75)
            {
                GradeRes.Text = "A";
            }
            else if (result <75 && result >= 70)
            {
                GradeRes.Text= "A-";
            }
            else if(result<70 && result >= 65)
            {
                GradeRes.Text = "B+";
            }
            else if(result <65 && result >=60)
            {
                GradeRes.Text = "B";
            }
            else if (result <60 && result >=55)
            {
                GradeRes.Text = "B-";
            }
            else if (result < 55 && result >= 50)
            {
                GradeRes.Text = "C+";
            }
            else if (result < 50 && result >= 45)
            {
                GradeRes.Text = "C";
            }
            else if (result < 45 && result >= 40)
            {
                GradeRes.Text = "B-";
            }
            else
            {
                GradeRes.Text = "F";
            }
            var name=Convert.ToString(StdTXT.Text);
            Obtained.Text =name+" obatained "+result.ToString("#.##")+"%  marks";

         }

    }
}