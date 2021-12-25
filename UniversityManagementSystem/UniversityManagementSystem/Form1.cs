using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class UniversityManagementSystem : Form
    {  
        List<StudentClass>studentClasses=new List<StudentClass>();
        List<AdminPeopleClass>adminPeopleClasses=new List<AdminPeopleClass>();
        List <TeacherClass>teacherClasses=new List<TeacherClass>();
        public UniversityManagementSystem()
        {
            InitializeComponent();
        }

        private void UniversityManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void StdSave_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(StudentIDtxt.Text);
            string name=StudentNametxt.Text;
            string sem= Semestertxt.Text;
            string department=StudentDepttxt.Text;

            StudentClass student = new StudentClass();
            student.SetSTDid(id);
            student.GetSTDid();
            student.setStdname(name);
            student.SetSem(sem);
            student.GetStdname();
            student.SetDepartment(department);
            student.GetSTDdepartment();
            studentClasses.Add(student);
            MessageBox.Show("Student information has been added successfully");
            ListofStudent.Items.Clear();
            foreach (StudentClass students in studentClasses)
            {
                ListofStudent.Items.Add(students.getInfo());
            }
        }

        private void TeachSave_Click(object sender, EventArgs e)
        {
            int  id = Convert.ToInt32(TeacherIDtxt.Text);
            string name = TeacherNametxt.Text;
            string designation = TeacherDesignationTXT.Text;
            string department = TeacherDeptTXT.Text;
            int  salary = Convert.ToInt32(TeacherSalaryTXT.Text);

            TeacherClass teacher= new TeacherClass();
            teacher.SetSalary(salary);
            teacher.GetSalary();
            teacher.SetTeacherDesignation (designation);
            teacher.GetTeacherDesignation();
            teacher.SetDepartment(department);
            teacher.GetDepartment();
            teacher.SetName(name);
            teacher.GetName();
            teacher.SetID(id);
            teacher.GetID();
            teacherClasses.Add(teacher);
            MessageBox.Show("Teacher's information has been added successfully");
            ListofTeachers.Items.Clear();
            foreach(TeacherClass teachers in teacherClasses)
            {
                ListofTeachers.Items.Add(teachers.getInfo());
            }
        }

        private void EmployeeSave_Click(object sender, EventArgs e)
        {
            int  id= Convert.ToInt32(EmployeeIDtxt.Text);
            string name = EmployeeTXT.Text;
            string designation= EmployeeDesignation.Text;
            int salary = Convert.ToInt32(EmployeeSalaryTXT.Text);
            AdminPeopleClass admin = new AdminPeopleClass();
            admin.SetID(id);
            admin.GetID();
            admin.SetDesignation(designation);
            admin.GetDesignation();
            admin.SetSalary(salary);
            admin.GetSalary();
            admin.SetName(name);
            admin.GetName();
            adminPeopleClasses.Add(admin);
            MessageBox.Show("Information of the employee has been added successfully");
            ListofAdminPeople.Items.Clear();
            foreach (AdminPeopleClass admins in adminPeopleClasses)
            {
                ListofAdminPeople.Items.Add(admins.getInfo());
            }
        }

        private void ListofStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StdClear_Click(object sender, EventArgs e)
        {
            StudentDepttxt.Clear();
            StudentIDtxt.Clear();
            StudentNametxt.Clear();
            Semestertxt.Clear();
        }

        private void TeachClear_Click(object sender, EventArgs e)
        {
            TeacherNametxt.Clear();
            TeacherIDtxt.Clear();
            TeacherDesignationTXT.Clear();
            TeacherDeptTXT.Clear();
            TeacherSalaryTXT.Clear();
        }

        private void AdminClear_Click(object sender, EventArgs e)
        {
           EmployeeTXT.Clear();
           EmployeeIDtxt.Clear();
           EmployeeSalaryTXT.Clear();
           EmployeeDesignationTXT.Clear();
        }

        private void StdShow_Click(object sender, EventArgs e)
        {   
            ListofStudent.Items.Clear();
            foreach (StudentClass student in studentClasses){
                ListofStudent.Items.Add(student.getInfo());
            }
        }

        private void TeachShow_Click(object sender, EventArgs e)
        {
            ListofTeachers.Items.Clear();
            foreach (TeacherClass teacher in teacherClasses)
            {
                ListofTeachers.Items.Add(teacher.getInfo());
            }

        }

        private void EmpShow_Click(object sender, EventArgs e)
        {
            ListofAdminPeople.Items.Clear();    
            foreach(AdminPeopleClass admin in adminPeopleClasses)
            {
                ListofAdminPeople.Items.Add(admin.getInfo());
            }
        }

        private void Semester_Click(object sender, EventArgs e)
        {

        }
    }
}
