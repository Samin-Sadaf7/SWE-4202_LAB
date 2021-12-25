using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    internal class TeacherClass
    {
        private string Teachname;
        private int    TeachID;
        private int    TeachSalary;
        private string TeachDepartment;
        private string TeachDesignation;
        public int GetID()
        {
            return TeachID;
        }
        public void SetID(int id)
        {
            TeachID = id;
        }
        public string GetName()
        {
            return Teachname;
        }
        public void SetName(string Name)
        {
            Teachname = Name;
        }
        public string GetDepartment()
        {
            return TeachDepartment;
        }
        public void SetDepartment(string department)
        {
            TeachDepartment = department;
        }
        public string GetTeacherDesignation()
        {
            return TeachDesignation;
        }
        public void SetTeacherDesignation(string designation)
        {
            TeachDesignation=designation;
        }
        public int GetSalary()
        {
            return TeachSalary;
        }
        public void SetSalary(int salary)
        {
            TeachSalary = salary;
        }
        public string getInfo()
        {
            string teachInfo = Convert.ToString(TeachID) + '\t' + Teachname + '\t' + TeachDepartment + '\t' +TeachDesignation+'\t'+ Convert.ToString(TeachSalary) ;
            return teachInfo;
        }
    }
}
