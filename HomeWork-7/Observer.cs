using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    public interface IObserver
    {
        void Update(float exchange);
    }
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifyObservers();

    }
    public class CurrencyExchange : ISubject
    {
        private float _usdExchange;
        private List<IObserver> _observers = new List<IObserver>();

        public void SetCurrency(float exchange)
        {
            _usdExchange = exchange;
            NotifyObservers();
        }
        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_usdExchange);
            }
        }
    }
    public class ConsoleObserver : IObserver
    {
        public void Update(float exchange)
        {
            Console.WriteLine($"Изменился курс валюты USD, новый курс: {exchange}");
        }
    }
    public class BankAppObserver : IObserver
    {
        public void Update(float exchange)
        {
            Console.WriteLine($"Новое уведомление с Банковского приложения: Изменился курс валюты USD, новый курс: {exchange}");
        }
    }
    public class EmailpObserver : IObserver
    {
        public void Update(float exchange)
        {
            Console.WriteLine($"Новое уведомление на Email: Изменился курс валюты USD, новый курс: {exchange}");
        }
    }
    internal class Observer
    {
    }
}
