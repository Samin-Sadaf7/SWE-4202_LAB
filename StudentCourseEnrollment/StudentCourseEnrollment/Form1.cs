using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseEnrollment
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Professional> professionals = new List<Professional>();
        List<Course> courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BeginnerRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddParticipantButton_Click(object sender, EventArgs e)
        {
            string name = ParticipantNameTXT.Text;
            string regNo = ParticipantRegTXT.Text;
            string contact = ParticipantContactTXT.Text;
            string email = ParticipantEmailTXT.Text;
            if (Beginner.Checked == true)
            { 
                string level = "Beginner";
                if (Student.Checked == true)
                {
                    Student dummy = new Student(name, regNo, contact, email,level);
                    EnrollStudentCombo.Items.Add(dummy.RegNo);
                    EnrollMentViewCombo.Items.Add(dummy.RegNo);
                    students.Add(dummy);

                    MessageBox.Show("Participant has been added successfully");
                }
                else if (Professional.Checked == true)
                {
                    Professional dummy = new Professional(name, regNo, contact, email,level);
                    EnrollStudentCombo.Items.Add(dummy.RegNo);
                    professionals.Add(dummy);
                    EnrollMentViewCombo.Items.Add(dummy.RegNo);
                    MessageBox.Show("Participant has been added successfully");
                }
                else
                {
                    MessageBox.Show("Select Type!");
                }
            }
            else if (Intermidiate.Checked == true)
            {
                string level = "Intermidiate";
                if (Student.Checked == true)
                {
                    Student dummy = new Student(name, regNo, contact, email,level);
                    EnrollStudentCombo.Items.Add(dummy.RegNo);
                    EnrollMentViewCombo.Items.Add(dummy.RegNo);
                    students.Add(dummy);

                    MessageBox.Show("Participant has been added successfully");
                }
                else if (Professional.Checked == true)
                {
                    Professional dummy = new Professional(name, regNo, contact, email,level);
                    EnrollStudentCombo.Items.Add(dummy.RegNo);
                    professionals.Add(dummy);
                    EnrollMentViewCombo.Items.Add(dummy.RegNo);
                    MessageBox.Show("Participant has been added successfully");
                }
                else
                {
                    MessageBox.Show("Select Type!");
                }
            }
            if (Advance.Checked == true)
            {
                string level = "Advance";
                if (Student.Checked == true)
                {
                    Student dummy = new Student(name, regNo, contact, email,level);
                    EnrollStudentCombo.Items.Add(dummy.RegNo);
                    EnrollMentViewCombo.Items.Add(dummy.RegNo);
                    students.Add(dummy);
                    MessageBox.Show("Participant has been added successfully");
                }
                else if (Professional.Checked == true)
                {
                    Professional dummy = new Professional(name, regNo, contact, email,level);
                    EnrollStudentCombo.Items.Add(dummy.RegNo);
                    EnrollMentViewCombo.Items.Add(dummy.RegNo);
                    professionals.Add(dummy);
                    MessageBox.Show("Participant has been added successfully");
                }
                else
                {
                    MessageBox.Show("Select Type!");
                }
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            string title = AddCourseTitleTXT.Text;
            string level = null;
            bool flag = false;
            if (CourseRegBeginnerRadio.Checked == true)
            {
                flag = true;
                level = "Beginner";
            }
            else if (CourseRegIntermidiateRadio.Checked == true)
            {
                flag = true;
                level = "Intermidiate";
            }
            else if (CourseRegAdvanceRatio.Checked == true)
            {   
                flag = true;
                level = "Advance";
            }
            else
            {   
                MessageBox.Show("Select Type");
            }
            double fee = Convert.ToDouble(BaseFeeofCourseTXT.Text);
            Course course = new Course(title, level, fee);
            EnrollCourseCombo.Items.Add(course.title);
            courses.Add(course);
            if (flag)
            {
                MessageBox.Show("Course Added");
            }
            else
            {
                MessageBox.Show("Fill up every items");
            }
        }

        private void CourseRegAdvanceRatio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void EnrollPayButton_Click(object sender, EventArgs e)
        {
            string reg = EnrollStudentCombo.Text;
            string course_title = EnrollCourseCombo.Text;
            string date = EnrollmentDatepicker.Text;
            double fee =0;
            bool flag = false;
            foreach (Student student in students)
            {
                if (student.RegNo == reg)
                {
                    foreach (Course course in courses)
                    {
                        if (course_title == course.title && student.level==course.level)
                        {
                            flag = true;
                            student.courses.Add(course);
                            fee = student.FeesPayable(course.fee);
                            student.totalPay=fee;
                            student.enroll_date = date;
                        }
                    }
                }
            }
            if (!flag)
            {
                foreach (Professional pro in professionals)
                {
                    if (pro.RegNo == reg)
                    {
                        foreach (Course course in courses)
                        {
                            if (course_title == course.title && pro.level == course.level)
                            {
                                flag = true;
                                pro.courses.Add(course);
                                double fees = course.fee;
                                fee = pro.FeesPayable(fees);
                                pro.totalPay = fee;
                                pro.enroll_date = date;
                            }
                        }
                    }
                }
            }
            if (flag)
            {
                CoursefeeShowLabel.Text = "Course fee:" + "\t" + fee.ToString();
                MessageBox.Show("Successfully Enrolled");
            }
            else
            {
                MessageBox.Show("Not applicable!");
            }
        }

        private void ShowEnrollmentButton_Click(object sender, EventArgs e)
        {
            string regNo= EnrollMentViewCombo.Text;
            bool flag = false;
            ShowStudentInfoList.Items.Clear();
            ShowStudentInfoList.Items.Add("Course Title" + "\t" + " Course Level" + "\t" + "Student Paid" + "\t" + "Enrollment Date");
            foreach(Student student in students)
            {
                if(student.RegNo == regNo)
                {
                    flag = true;
                    ShowStudentInfoList.Items.Add(student.StudInfo(student));
                }
            }
            if (!flag)
            {
                foreach(Professional pro in professionals)
                {
                    flag = true;
                    ShowStudentInfoList.Items.Add(pro.Proinfo(pro));
                }
            }
        }

        private void EnrollCourseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
