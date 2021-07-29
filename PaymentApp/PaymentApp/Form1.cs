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
            /*Random num = new Random();
            int discount = num.Next(1, 100);*/
            Payment p = new Payment();
            int discount = p.discountGenerator();

            // Generate amount to pay
            p.amountToPay = int.Parse(amountToPayTxt.Text);

            // Set cashIn amount
            /*int cashIn = int.Parse(amountTxt.Text);*/
            p.cashIn = int.Parse(amountTxt.Text);

            // Set Payment Type
            p.paymentType = paymentType();

            // Set discounted amount
            int discountedAmount = p.discountedAmount(p.amountToPay, discount);

            // Set balance
            /*int balance = discountedAmount - cashIn;*/
            int balance = p.balance(discountedAmount, p.cashIn);

            displayResult(p.paymentType, p.amountToPay, p.cashIn, discount, discountedAmount, balance);
        }
        public void displayResult(string paymentType, int amountToPay, int cashIn, int discount, int discountedAmount, int balance)
        {
            string output_format = "Payment type: " + paymentType +
                "\nAmount to Pay: " + amountToPay +
                "\nCash In: " + cashIn +
                "\nDiscount rewarded: " + discount +
                "\nDiscounted Amount: " + discountedAmount +
                "\nPaid Amount: " + cashIn +
                "\nBalance: " + balance;
            DialogResult d = MessageBox.Show(output_format
                , "Payment Summary", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes) Close();
        }

        public string paymentType()
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
