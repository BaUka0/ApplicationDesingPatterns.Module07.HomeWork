using System;

namespace HomeWork_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            PaymentContext paymentContext = new PaymentContext(new PayPalPayment());
            paymentContext.ProcessPayment(300);

            paymentContext.ChangePayment(new CreditCardPayment());
            paymentContext.ProcessPayment(400);

            paymentContext.ChangePayment(new CryptoPayment());
            paymentContext.ProcessPayment(500);

            CurrencyExchange currencyExchange = new CurrencyExchange();

            IObserver console = new ConsoleObserver();
            IObserver bankApp = new BankAppObserver();
            IObserver email = new EmailpObserver();

            currencyExchange.Subscribe(console);
            currencyExchange.Subscribe(bankApp);
            currencyExchange.Subscribe(email);
            currencyExchange.SetCurrency(490.5f);
            currencyExchange.Unsubscribe(console);
            currencyExchange.SetCurrency(486.45f);
        }
    }
}