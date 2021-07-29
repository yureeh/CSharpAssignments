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
    }
}
