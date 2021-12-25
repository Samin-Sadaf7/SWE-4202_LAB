using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    internal class AdminPeopleClass
    {
        private string Adname;
        private int  AdID;
        private int  AdSalary;
        private string AdDesignation;
        public string GetName()
        {
            return Adname;
        }
        public void SetName(string Name)
        {
            Adname = Name;
        }
        public int GetID()
        {
            return AdID;
        }
        public void SetID(int ID)
        {
            AdID = ID;
        }
        public int GetSalary()
        {
            return AdSalary;
        }
        public void SetSalary(int salary)
        {
            AdSalary = salary;
        }
        public string GetDesignation()
        {
            return AdDesignation;
        }
        public void SetDesignation(string designation)
        {
            AdDesignation = designation;
        }
        public string  getInfo()
        {
            string adInfo= Convert.ToString(AdID)+'\t'+Adname+'\t'+AdDesignation+'\t'+Convert.ToString(AdSalary)+'\t';
            return adInfo;
        }
    }
}
