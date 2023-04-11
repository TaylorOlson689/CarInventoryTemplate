using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
         List<Cars> carsDB = new List<Cars>();

        public mainForm()
        {
            InitializeComponent();
            loadDB();
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, colour, mileage;

            year = yearInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            Cars newCar = new Cars(year,  make, colour, mileage);
            carsDB.Add(newCar);

            foreach(Car c in cars)
            {
                outputLabel.Text += $"{c.make} {c.colour} {c.year} {c.mileage}\n";
            }

            ClearLabels();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (Car c in cars)
            {
                if (c.make == makeInput.Text)
                {
                    cars.Remove(c);
                    break;
                }
            }
        }
    }
}
