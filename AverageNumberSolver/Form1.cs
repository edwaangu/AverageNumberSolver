using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageNumberSolver
{
    public partial class Form1 : Form
    {
        double sum = 0;
        double totalNumbers = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Find the number inputted
            double addedNum = Convert.ToDouble(inputBox.Text);

            // If the number is 0, then add the numbers together
            if(addedNum == 0)
            {
                if(totalNumbers == 0)
                {
                    outputLabel.Text = "You need to add at least one number first!";
                    return;
                }
                double sumAverage = sum / totalNumbers;
                outputLabel.Text = $"The average of all numbers added to the sum is: {sumAverage.ToString("0.00")}";
            }
            else
            {
                sum += addedNum;
                totalNumbers++;
                outputLabel.Text = $"{addedNum} was added to the sum.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = 0;
            totalNumbers = 0;
            outputLabel.Text = "";
            inputBox.Text = "";
        }
    }
}
