using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Decorator.CQRS.Interfaces;
using Patterns.Decorator.CQRS.Models;

namespace Patterns.Decorator.CQRS.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _data = new List<Order>
        {
            new Order
            {
                Id = Guid.Parse("5d137f6b-8019-4400-8dad-5d74e3bdad51"),
                Date = new DateTime(2020, 01, 02),
                Total = 12.34m
            },
            new Order
            {
                Id = Guid.Parse("5d137f6b-8019-4400-8dad-5d74e3bdad52"),
                Date = new DateTime(2020, 02, 02),
                Total = 56.78m
            },
            new Order
            {
                Id = Guid.Parse("5d137f6b-8019-4400-8dad-5d74e3bdad53"),
                Date = new DateTime(2020, 02, 02),
                Total = 90.12m
            }
        };

        public Order Get(Guid id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order order)
        {
            // Successful update
        }

        public IEnumerable<Order> Get()
        {
            return _data;
        }
    }
}