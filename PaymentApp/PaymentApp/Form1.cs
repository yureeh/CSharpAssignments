using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random num = new Random();
            amountToPayTxt.Text = num.Next(1, 100000).ToString();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            // Generate random discount
            Payment p = new Payment();
            int discount = p.discountGenerator();

            // Generate amount to pay
            p.amountToPay = int.Parse(amountToPayTxt.Text);

            // Set cashIn amount
            p.cashIn = int.Parse(amountTxt.Text);

            // Set Payment Type
            p.paymentType = paymentTypeAction();

            // Set discounted amount
            int discountedAmount = p.discountedAmount(p.amountToPay, discount);

            // Set balance
            int balance = p.balance(discountedAmount, p.cashIn);
            string output_format = p.displayResult(p.paymentType, p.amountToPay, p.cashIn, discount, discountedAmount, balance);
            DialogResult d = MessageBox.Show(output_format
                , "Payment Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes) Close();
        }

        public string paymentTypeAction()
        {
            string paymentType = "";
            bool isCheckedCashRd = cashRd.Checked;
            bool isCheckedCreditRd = creditRd.Checked;
            bool isCheckedBank = bankRd.Checked;

            if (isCheckedCashRd) paymentType = cashRd.Text;
            else if (isCheckedCreditRd) paymentType = creditRd.Text;
            else if (isCheckedBank) paymentType = bankRd.Text;
            else paymentType = "Invalid type of payment...";

            return paymentType;
        }
    }
}
