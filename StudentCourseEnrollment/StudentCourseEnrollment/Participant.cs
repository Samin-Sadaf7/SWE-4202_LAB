using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment
{
    abstract internal class Participant
    {
        public string Name;
        public string RegNo;
        public string ContactNo;
        public string Email;
        public double totalPay;
        public string enroll_date;
        public string level;    
        public List<Course> courses = new List<Course>();
        public abstract double FeesPayable(double fee);

    }
}
