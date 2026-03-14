using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Payment using Credit Card");
        }
    }
}
