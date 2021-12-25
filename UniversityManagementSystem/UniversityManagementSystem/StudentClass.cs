using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    internal class StudentClass
    {
        private string Stdname;
        private int  StdID;
        private string StdSem;
        private string StdDepartment;
        public int GetSTDid() { return StdID;  }
        public void SetSTDid(int ID) { StdID = ID; }
        public string GetSTDsem() {return StdSem;}
        public string GetSTDdepartment() { 
            return StdDepartment;
        }
        public string GetStdname() {
            return Stdname;
        }
        public void SetSem(string Sem) { StdSem = Sem;}
        public void SetDepartment(string Department)
        {
            StdDepartment = Department;
        }
        public void setStdname(string Name) { 
            Stdname = Name;
        }

        public string getInfo()
        {
            string StdInfo = Convert.ToString(StdID) + '\t' + Stdname + '\t' + StdDepartment + '\t' + StdSem + '\t';
            return StdInfo;
        }
    }
}
