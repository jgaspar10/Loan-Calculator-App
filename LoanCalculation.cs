using System;
using System.Windows.Forms;

namespace LoanCalculatorApp
{
    public partial class LoanCalculation : Form
    {
        public LoanCalculation()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double interestRate, monthlyInterestRate, loanAmount, monthlyPayments, totalPayments;
            int durationYears;
            String displayMonthlyPayments, displayTotalPayments;

            if (string.IsNullOrWhiteSpace(txb_amount.Text) ||
                string.IsNullOrWhiteSpace(txb_duration.Text) ||
                string.IsNullOrWhiteSpace(txb_rate.Text))

            {
                MessageBox.Show("Please enter details");
                return;
            }
            {
                interestRate = Convert.ToDouble(txb_rate.Text);
                monthlyInterestRate = interestRate / 1200;
                durationYears = Convert.ToInt32(txb_duration.Text);
                loanAmount = Convert.ToDouble(txb_amount.Text);

                monthlyPayments = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, durationYears * 12));
                totalPayments = monthlyPayments * durationYears * 12;

                txb_amount.Text = String.Format("{0:C}", loanAmount);
                displayMonthlyPayments = String.Format("{0:C}", monthlyPayments);
                displayTotalPayments = String.Format("{0:C}", totalPayments);


                displayMonthlyPayments = Convert.ToString(monthlyPayments);
                label_monthlypayment.Text = (displayMonthlyPayments);
                label_totalpayment.Text = (displayTotalPayments);

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txb_amount.Clear();
            txb_duration.Clear();
            txb_rate.Clear();
        }
    }
}

