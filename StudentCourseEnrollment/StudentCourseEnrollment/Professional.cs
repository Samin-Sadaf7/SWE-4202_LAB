using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment
{
    internal class Professional:Participant
    {
        public override double FeesPayable(double fee)
        {
            double extra = (10 / 100) * fee;
            return fee+extra;
        }
        public Professional(string name, string reg, string contact, string email,string level)
        {
            this.Name = name;
            this.RegNo = reg;
            this.ContactNo = contact;
            this.Email = email;
            this.level = level;
        }
        public string Proinfo(Professional pro)
        {
            foreach (Course course in pro.courses)
            {
                return course.title + "\t"+"\t" + course.level + "\t"+"\t" + pro.totalPay.ToString() + "\t" +"\t"+ pro.enroll_date;
            }
            return null;
        }
        public Professional(){

        }
    }
}
