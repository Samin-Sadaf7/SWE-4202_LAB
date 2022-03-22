using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_Result_Processing_App
{
    internal class Student
    {
        public string ID;
        public string Name;
        public double Attendance;
        public double MID;
        public double [] Quiz=new double[4];
        public double Final;
        public double Viva;
        public double averagePercentage;
        public string Grade;
        public double Total;
        public double QuizTotal;
        public Student(string ID, string Name, string Attendance, string Quiz1, string Quiz2, string Quiz3,string Quiz4,string Mid, string Final, string Viva)
        {
            this.ID = ID;
            this.Name = Name;
            if(Attendance=="")
            {
                Attendance = "0";
            }
            if(Quiz1=="")
            {
                Quiz1 = "0";
            }
            if (Quiz2 =="")
            {
                Quiz2 = "0";
            }
            if(Quiz3=="")
            {
                Quiz3 = "0";
            }
            if(Quiz4=="")
            {
                Quiz4 = "0";
            }
            if(Mid=="")
            {
                Mid = "0";
            }
            if(Final=="")
            {
                Final= "0";
            }
            if(Viva=="")
            {
                Viva = "0";
            }
            this.Attendance = Convert.ToDouble(Attendance);
            this.MID = Convert.ToDouble(Mid);
            this.Quiz[0]=Convert.ToDouble(Quiz1);
            this.Quiz[1]=Convert.ToDouble(Quiz2);
            this.Quiz[2]=Convert.ToDouble(Quiz3);
            this.Quiz[3]=Convert.ToDouble(Quiz4);
            this.Final = Convert.ToDouble(Final);
            this.Viva = Convert.ToDouble(Viva);
        }
        public double averagerPercentageCalc(double Attendance,double MID, double Quiz_Total, double Final, double Viva)
        {
            double Total= Quiz_Total+ Final+Viva+Attendance+MID;
            Total = (Total / 3);
            return Total;
        }
        public double TotalNumber(double Attendance, double MID, double Quiz_Total, double Final, double Viva)
        {
            double Total = Quiz_Total + Final + Viva + Attendance+MID;
            return Total;
        }
        public double BestQuizCalc()
        {
            double[] quiz_dumb = new double[4];
            for(int i = 0; i < 4; i++)
            {
                quiz_dumb[i] = this.Quiz[i];

            }
            Array.Sort(quiz_dumb);
            return quiz_dumb[1]+quiz_dumb[2]+quiz_dumb[3]; 
        }
        public string CalcGrade(double averagePercentage)
        {
            string letterGrade;
            double percentage=averagePercentage;
            if (percentage >= 80)
                letterGrade = "A+";
            else if (percentage < 80 && percentage >= 75)
                letterGrade = "A";
            else if (percentage < 75 && percentage >= 70)
                letterGrade = "A-";
            else if (percentage >= 65 && percentage < 70)
                letterGrade = "B+";
            else if (percentage < 65 && percentage >= 60)
                letterGrade = "B";
            else if (percentage < 60 && percentage >= 55)
                letterGrade = "B-";
            else if (percentage < 55 && percentage >= 50)
                letterGrade = "C+";
            else if (percentage < 50 && percentage >= 45)
                letterGrade = "C";
            else if (percentage < 45 && percentage >= 40)
                letterGrade = "D";
            else
                letterGrade = "F";
            return letterGrade;

        }
    }
}
