using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
   
    internal class Car
    {
        public string year, make, colour, mileage;

        public Car(string year, string make, string colour, string mileage)
        {
           year = year;
           make = make;
           colour = colour;
           mileage = mileage;

            Cars newCar = new Cars(year,  make, colour, mileage);
            carsDB.Add(newCar);

            ClearLabels();
        }

        public Car(string year, string make, string colour, string mileage)
        {
           year = year;
           make = make;
           colour = colour;
           mileage = mileage;

            Cars newCar = new Cars(year,  make, colour, mileage);
            carsDB.Add(newCar);

            ClearLabels();
        }

        private void ClearLabels()
        {
            idInput.Text = "";
            fnInput.Text = "";
            lnInput.Text = "";
            dateInput.Text = "";
            salaryInput.Text = "";
        }
    }
}
