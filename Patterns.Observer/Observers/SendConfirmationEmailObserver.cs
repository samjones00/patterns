using System;
using System.Diagnostics;
using Patterns.Observer.Models;

namespace Patterns.Observer.Observers
{
    public class SendConfirmationEmailObserver : IObserver<Order>
    {
        private IDisposable _unsubscriber;
        public string Reference { get; set; }

        public SendConfirmationEmailObserver(Order order)
        {
            this.Reference = order.Ref;
        }
        
        public virtual void Subscribe(IObservable<Order> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
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
            Debug.WriteLine($"Confirmation email sent for order ref #{order.Ref} ");
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
