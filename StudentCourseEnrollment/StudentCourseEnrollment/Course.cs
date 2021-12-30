using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollment
{
    internal class Course
    {
        public string title;
        public string level;
        public double fee;
        public string date;

        public Course(string title, string level, double fee)
        {
            this.title = title;
            this.level = level;
            this.fee = fee;
        }
        public Course()
        {

        }
    }    
}
