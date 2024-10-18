using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    public interface IPaymentStrategy
    {
        void Pay(int amount);
    }
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Произведена оплата по карте на сумму: {amount}");
        }
    }
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Произведена оплата по PayPal на сумму: {amount}");
        }
    }
    public class CryptoPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Произведена оплата с помощью криптовалюты на сумму: {amount}");
        }
    }
    public class PaymentContext
    {
        private IPaymentStrategy _payment;
        public PaymentContext(IPaymentStrategy payment)
        {
            _payment = payment;
        }
        public void ChangePayment(IPaymentStrategy payment)
        {
            _payment = payment;
        }
        public void ProcessPayment(int amount)
        {
            _payment.Pay(amount);
        }
    }
    internal class Strategy
    {
    }
}
