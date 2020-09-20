using System;
using System.Collections.Generic;
using Patterns.Observer.Exceptions;
using Patterns.Observer.Models;

namespace Patterns.Observer
{
    public class OrderObservable : IObservable<Order>
    {
        public OrderObservable()
        {
            observers = new List<IObserver<Order>>();
        }

        private List<IObserver<Order>> observers;

        public IDisposable Subscribe(IObserver<Order> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Order>> _observers;
            private IObserver<Order> _observer;

            public Unsubscriber(List<IObserver<Order>> observers, IObserver<Order> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void PlaceOrder(Order? order)
        {
            foreach (var observer in observers)
            {
                if (!order.HasValue || string.IsNullOrEmpty(order.Value.Ref))
                    observer.OnError(new InvalidOrderException());
                else
                    observer.OnNext(order.Value);
            }
        }

        public void Unsubscribe()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}