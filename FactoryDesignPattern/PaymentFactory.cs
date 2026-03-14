using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PaymentFactory
    {
        public static IPayment CreatePayment(string paymentType)
        {
            if (paymentType == "credit")
            {
                return new CreditCardPayment();
            }
            else if (paymentType == "paypal")
            {
                return new PayPalPayment();
            }

            throw new Exception("Invalid Payment Type");
        }
    }
}
