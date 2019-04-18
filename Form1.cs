using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth;
            DateTime.TryParse(txtDoB.Text, out dateOfBirth);
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate.Subtract(dateOfBirth);
            DateTime age = DateTime.MinValue + difference;
            int ageInYears = age.Year - 1;
            int ageInMonths = age.Month - 1;
            int ageInDays = age.Day - 1;

            txtAiY.Text = (ageInYears).ToString();
            txtAiM.Text = (ageInMonths).ToString();
            txtAiD.Text = (ageInDays).ToString();
        }

        private void btnCal_MouseMove(object sender, MouseEventArgs e)
        {
           // toolTip1.SetToolTip(this.btnCal, "Entter to Calculate Your Age");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you really want to close", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
