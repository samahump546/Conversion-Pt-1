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
                InchesToCm(inches);
            }
            else if (choiceInput.Text == "2")
            {
                double feet = Convert.ToDouble(valueInput.Text);
                FeetToCm(feet);
            }
            else if (choiceInput.Text == "3")
            {
                double yards = Convert.ToDouble(valueInput.Text);
                YardsToMetres(yards);
            }
            else if (choiceInput.Text == "4")
            {
                double miles = Convert.ToDouble(valueInput.Text);
                MilesToKm(miles);
            }
        }

        public void InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            convertOutput.Text = $"{inches} inches = {cm.ToString("0.00")} centimetres";
        }

        public void FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            convertOutput.Text = $"{feet} feet = {cm.ToString("0.00")} centimetres"; 
        }

        public void YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            convertOutput.Text = $"{yards} yards = {metres.ToString("0.00")} metres";
        }

        public void MilesToKm(double miles)
        {
            double km = miles * 1.6;
            convertOutput.Text = $"{miles} miles = {km.ToString("0.00")} kilometres";
        }
    }

}
