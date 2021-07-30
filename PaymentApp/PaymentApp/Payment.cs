using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp
{
    class Payment
    {
        public int amountToPay { get; set; }
        public string paymentType { get; set; }
        public int cashIn { get; set; }

        public int discountGenerator()
        {
            Random num = new Random();
            return num.Next(1, 100);
        }

        public int discountedAmount(int amountToPay, int discount)
        {
            return (amountToPay * discount) / 100;
        }

        public int balance(int total_amount, int amount)
        {
            return total_amount - amount;
        }
        public string displayResult(string paymentType, int amountToPay, int cashIn, int discount, int discountedAmount, int balance)
        {
            string output_format = "Payment type: " + paymentType +
                "\nAmount to Pay: " + amountToPay +
                "\nCash In: " + cashIn +
                "\nDiscount rewarded: " + discount +
                "\nDiscounted Amount: " + discountedAmount +
                "\nPaid Amount: " + cashIn +
                "\nBalance: " + balance;
            return output_format;
        }

    }

    class Cash : Payment
    {

    }

    class CreditCard : Payment
    {

    }

    class BanK : Payment
    {

    }
}
