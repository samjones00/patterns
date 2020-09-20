using System;
using System.Diagnostics;
using Patterns.Observer.Models;

namespace Patterns.Observer.Observers
{
    public class NotifyWarehouseObserver : IObserver<Order>
    {
        private IDisposable unsubscriber;
        public string Reference { get; set; }

        public NotifyWarehouseObserver(Order order)
        {
            this.Reference = order.Ref;
        }

        public virtual void Subscribe(IObservable<Order> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Debug.WriteLine($"Unsubscribing {this.GetType()}.");
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Debug.WriteLine($"An error occurred in {this.GetType()}");
        }

        public void OnNext(Order order)
        {
            Debug.WriteLine($"Order ref# {order.Ref} requires packing");
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
