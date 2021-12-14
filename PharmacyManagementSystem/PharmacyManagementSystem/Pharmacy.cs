using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Pharmacy : Form
    {   
        List<Medicine> Medicines= new List<Medicine>();
        double TotalAccount=0;
        public Pharmacy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddMed_Click(object sender, EventArgs e)
        {
            string name= AddMedNameTXT.Text;
            string company= AddCompanyTXT.Text;
            int stock= Convert.ToInt32(AddStockTXT.Text);
            double price= Convert.ToDouble(AddPriceTXT.Text);
            int serial = Convert.ToInt32(SerialTXT.Text);
            Medicine med= new Medicine(name, company,stock, price,serial);
            Medicines.Add(med);
            MedicineNames.Items.Add(med.name);
            ShowMedicineNames.Items.Add(med.name);
            MessageBox.Show("Medicine has been added successfully");
        }

        private void SellMed_Click(object sender, EventArgs e)
        {
            string name = MedicineNames.Text;
            int pieces = Convert.ToInt32(Num_PiecesTXT.Text);
            bool flag = false;
            foreach(Medicine med in Medicines)
            {
                if (med.name == name && med.stock>=pieces)
                {   
                    flag = true;
                    med.stock = med.stock-pieces;
                    TotalAccount = TotalAccount+med.price*pieces;
                    MessageBox.Show("Medicine has been sold");
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Medicine is Unavailable");
            }
        }

        private void ShowMed_Click(object sender, EventArgs e)
        {
            string name =ShowMedicineNames.Text;
            bool flag = false;  
            foreach(Medicine med in Medicines)
            {
                if (med.name == name)
                {   
                    flag= true;
                    Show_Name.Text = "Medicine Name:" + " " + med.name;
                    Show_Med_Stock.Text = "Current Stock" + " " + med.stock.ToString();
                    Total_Account.Text = " Current Account Balance" + " " + TotalAccount.ToString();
                    break;
                }
            }
            if(flag == false)
            {
                MessageBox.Show("The Medicine does not exist");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
