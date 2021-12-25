using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingApp
{
    public partial class CarRent : Form
    {
        List<User> users = new List<User>();
        List<Car>cars = new List<Car>();    
        bool Userexist(int UserID)
        {
            foreach(User user in users)
            {
                if(user.id == UserID)
                {
                    return true;
                }
               
            }
            return false;
        }
        bool CarExists( string CarName)
        {
            foreach(Car car in cars)
            {
                if (car.name == CarName)
                {
                    return true;
                }
            }
            return false;
        }
        public CarRent()
        {
            InitializeComponent();
        }

        private void UserSave_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(UserIDtxt.Text);
            string Name= UserNameTXT.Text;
            string address= AddressTxt.Text;
            string destination = DestinationTXT.Text;
            User user =new User(id,Name,address,destination);
            users.Add(user);
            MessageBox.Show("User has been added successfully");
        }

        private void UserIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarSave_Click(object sender, EventArgs e)
        {
            string name = CarNametxt.Text;
            string Model = CarModelTxt.Text;
            int numbers= Convert.ToInt32(CarNumberTXT.Text);
            Car car = new Car(name, Model,numbers);
            cars.Add(car);
            MessageBox.Show("Car has been added successsfully");
        }

        private void RentCar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(RentUserIDtxt.Text);
            string name=RentthisCartxt.Text;
            if (Userexist(id) && CarExists(name))
            {
                foreach (User user in users)
                {
                    foreach (Car car in cars)
                    {
                        if (car.name == name)
                        {
                            if (car.NumberofCars < 1)
                            {
                                MessageBox.Show("Out of stock");
                                break;
                            }
                            user.rentedcar = name;
                            car.NumberofCars =car.NumberofCars-1;
                            MessageBox.Show("Borrowed Successfully");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Not possible");
            }
        }

        private void ShowUserHistory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(HistoryUserIDTxt.Text);
            if (Userexist(id))
            {
                foreach(User user in users)
                {
                    if(user.id== id)
                    {
                        UserNameLabel.Text = user.name;
                        AddressLabel.Text = user.address;
                        RentedCarLabel.Text = user.rentedcar;
                        DestinationLabel.Text = user.destination;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("User does not exist");
            }
        }

        private void ShowCarHistory_Click(object sender, EventArgs e)
        {
            string name = HistoryCarName.Text;
            string model = HistoryCarModelTxt.Text;
         
            if (CarExists(name))
            {
                foreach(Car car in cars)
                {
                    if (car.model == model)
                    {
                       AvaiableUnitShowLabel.Text = Convert.ToString(car.NumberofCars);
                       break; 
                    }
                }
            }
            else
            {
                MessageBox.Show("Car does not exist");
            }
        }
    }
}
