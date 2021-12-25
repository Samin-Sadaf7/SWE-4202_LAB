using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingApp
{
    internal class Car
    {
        public string name;
        public string model;
        public int NumberofCars;
        public Car(string name, string model, int NumbersofCars)
        {
            this.name = name;   
            this.model = model;
            this.NumberofCars = NumbersofCars;
        }
    }
}
