using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //send values to the ConvertValues method
            if (choiceInput.Text == "1")
            {
                double inches = Convert.ToDouble(valueInput.Text);
                double answer = InchesToCm(inches);
                convertOutput.Text = $"{inches} inches = {answer.ToString("0.00")} centimetres";
            }
            else if (choiceInput.Text == "2")
            {
                double feet = Convert.ToDouble(valueInput.Text);
                double result = FeetToCm(feet);
                convertOutput.Text = $"{feet} feet = {result.ToString("0.00")} centimetres";
            }
            else if (choiceInput.Text == "3")
            {
                double yards = Convert.ToDouble(valueInput.Text);
                double outcome = YardsToMetres(yards);
                convertOutput.Text = $"{yards} yards = {outcome.ToString("0.00")} metres";
            }
            else if (choiceInput.Text == "4")
            {
                double miles = Convert.ToDouble(valueInput.Text);
                double sum = MilesToKm(miles);
                convertOutput.Text = $"{miles} miles = {sum.ToString("0.00")} kilometres";
            }
        }

        public double InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        public double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        public double YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            return metres;
        }

        public double MilesToKm(double miles)
        {
            double km = miles * 1.6;
            return km;
        }
    }

}
