using System;
using System.Windows.Forms;

namespace August22_1
{
    public partial class BasicForm1 : Form
    {
        public BasicForm1()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            tbHoursWorked.Clear();
            tbHourlyPayRate.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hoursWorked;
            double hourlyPayRate;
            double grossPay;

            if (double.TryParse(tbHoursWorked.Text, out hoursWorked)
                && double.TryParse(tbHourlyPayRate.Text, 
                out hourlyPayRate))
            {
                grossPay = hourlyPayRate * hoursWorked;
                MessageBox.Show("Gross Pay" + grossPay.ToString("c")
                    );
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
