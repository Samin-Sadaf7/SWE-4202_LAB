using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment
{
    internal class Student:Participant
    {
        public Student(string name, string reg, string contact, string email,string level)
        {
            this.Name=name;
            this.RegNo=reg;
            this.ContactNo=contact;
            this.Email=email;
            this.level=level;
        }
        public override double FeesPayable(double fee)
        {

            double total=(fee+0.1*fee);
            return total;
        }
        public string StudInfo(Student std)
        {   
           foreach(Course course in std.courses)
            {
                return course.title+"\t"+"\t"+course.level+"\t"+"\t"+std.totalPay.ToString()+"\t"+"\t"+std.enroll_date;
            }
            return null;
        }
        public Student()
        {

        }
       
    }
}
