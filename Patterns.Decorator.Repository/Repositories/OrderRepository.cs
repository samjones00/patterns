using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Decorator.Repository.Interfaces;
using Patterns.Decorator.Repository.Models;

namespace Patterns.Decorator.Repository.Repositories
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
            }
        };

        public Order Get(Guid id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }
    }
}