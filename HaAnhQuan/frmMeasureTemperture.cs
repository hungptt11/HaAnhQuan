/// <summary>
/// Name : Ha Anh Quan
/// Date : 10/06/2021
/// Description : Measuring application to calculate the freeze percentage and show report to the screen
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HaAnhQuan
{
    public partial class frmCoolingReport : Form
    {
        public frmCoolingReport()
        {
            InitializeComponent();

        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Please enter the right input number");
                return;
            }

            var leftPercent = CalculatePercentage(int.Parse(txtStartingTemp.Text), int.Parse(txtCurrentTemp.Text));
            progressTemp.Value = leftPercent;
        }

        private int CalculatePercentage(int startingTemp, int currentTemp)
        {
            int percent = (int)Math.Ceiling((double)(100 * currentTemp) / startingTemp);
            var leftPercent = 100 - percent;
            if (Over85(leftPercent))
            {
                lblProgressReport.Text = $"Progress Report: only {currentTemp} degrees to go";
            }
            else
            {
                lblProgressReport.Text = $"Progress Report: the sample is {leftPercent} % of the way to freezing";
            }
            return percent;
        }


        private bool Over85(int param)
        {
            return param > 85;
        }


        private bool ValidateInput()
        {
            int startingTemp = 0;
            if (!int.TryParse(txtStartingTemp.Text, out startingTemp))
            {
                return false;
            }
            int currentTemp = 0;
            if (!int.TryParse(txtCurrentTemp.Text, out currentTemp))
            {
                return false;
            }
            if (currentTemp < 0 || currentTemp > startingTemp)
            {
                return false;
            }
            return true;
        }

        private void txtStartingTemp_Leave(object sender, EventArgs e)
        {
            int startingTemp = 0;
            if (int.TryParse(txtStartingTemp.Text, out startingTemp))
            {
                lblHeighest.Text = startingTemp.ToString();
                lblMiddle.Text = ((int)Math.Ceiling((double)startingTemp / 2)).ToString();
            }
        }

        private void frmCoolingReport_Load(object sender, EventArgs e)
        {
            btnProgress_Click(null, new EventArgs());
        }
    }
}
