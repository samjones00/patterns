using System;
using System.Collections.Generic;
using Patterns.Decorator.CQRS.Models;

namespace Patterns.Decorator.CQRS.Interfaces
{
    public interface IOrderRepository
    {
        public Order Get(Guid id);
        public void Update(Order order);
        public IEnumerable<Order> Get();
    }
}
