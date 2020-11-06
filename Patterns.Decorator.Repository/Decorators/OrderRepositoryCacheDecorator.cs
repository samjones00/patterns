using System;
using System.Collections.Generic;
using Patterns.Decorator.Repository.Interfaces;
using Patterns.Decorator.Repository.Models;
using Patterns.Decorator.Repository.Repositories;

namespace Patterns.Decorator.Repository.Decorators
{
    public class OrderRepositoryCacheDecorator : OrderRepository, IOrderRepository
    {
        private readonly Dictionary<Guid, Order> _cache = new Dictionary<Guid, Order>();

        public new Order Get(Guid id)
        {
            _cache.TryGetValue(id, out var cachedOrder);

            if (cachedOrder != null)
                return cachedOrder;

            var nonCachedOrder = base.Get(id);

            _cache.Add(id, nonCachedOrder);

            return nonCachedOrder;
        }
    }
}