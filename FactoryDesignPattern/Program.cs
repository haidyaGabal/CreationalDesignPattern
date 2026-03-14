namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                IPayment payment1 = PaymentFactory.CreatePayment("credit");
                payment1.Pay();

                IPayment payment2 = PaymentFactory.CreatePayment("paypal");
                payment2.Pay();
            }
        }
    }
    
