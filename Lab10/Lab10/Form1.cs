using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Employee> employees = new List<Employee>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\Hp\Downloads\employees.csv"))
            {
               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Employee employee = new Employee();
                    employee.ID = values[0];
                    employee.First_Name = values[1];
                    employee.Last_Name = values[2];
                    employee.salary = values[9];
                    employee.Hiring_Date = values[5];
                    employee.Address = values[3];
                    employees.Add(employee);
                    EmployeeList.Items.Add(employee.ID + "\t" + employee.First_Name + "\t" + employee.Last_Name);
                }
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(Employee emp in employees)
            {
                if(emp.ID == ID_TextBox.Text)
                {
                    flag = true;
                    ShowLabel.Text = "Name:" + "\t" + emp.First_Name + "\t" + emp.Last_Name + "\n" + "ID:" + "\t" + emp.ID + "\n" + "Address" + "\t" + emp.Address + "\n" + "Hiring Date:" + "\t" + emp.Hiring_Date + "\n" + "Salary:" + "\t" + emp.salary;
                    using (StreamWriter write = File.AppendText(@"C:\Users\Hp\OneDrive\Desktop\LAB10_Analytics.txt"))
                    {
                        write.WriteLine(emp.ID + "\t" + "Yes" + "\t" + emp.First_Name + "\t" + emp.Last_Name + "\t" + emp.Address + "\t"+"\n");
                        write.Close();

                    }       
                }
            }
            if (!flag)
            {
                MessageBox.Show("ID did not found");
                using (StreamWriter write = File.AppendText(@"C:\Users\Hp\OneDrive\Desktop\LAB10_Analytics.txt"))
                {
                    write.WriteLine(ID_TextBox.Text+"\t"+"No"+"\n");
                    write.Close();
                }
            }
          
        }
    }
}
