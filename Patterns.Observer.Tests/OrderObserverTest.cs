using System;
using System.Linq;
using Patterns.Observer.Models;
using Patterns.Observer.Observers;
using Xunit;

namespace Patterns.Observer.Tests
{
    public class OrderObserverTest
    {
        [Fact]
        public void Test()
        {
            var order = new Order
            {
                Ref = "12345",
            };

            var orderObservable = new OrderObservable();
            var sendConfirmationEmailObserver = new SendConfirmationEmailObserver(order);
            var notifyWarehouseObserver = new NotifyWarehouseObserver(order);

            sendConfirmationEmailObserver.Subscribe(orderObservable);
            notifyWarehouseObserver.Subscribe(orderObservable);

            orderObservable.PlaceOrder(order);
            orderObservable.Unsubscribe();
        }
    }
}
