using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reimbursement_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate = .39, amountOwed;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 999999;
            numericUpDown2.Maximum = 999999;
            labelAmount.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDisplayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelAmountOwed_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                startingMileage = (int)numericUpDown1.Value;
                endingMileage = (int)numericUpDown2.Value;
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                labelAmount.Text = "$" + amountOwed;
                labelAmount.Visible = true;
            }
            else 
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Focus();
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
