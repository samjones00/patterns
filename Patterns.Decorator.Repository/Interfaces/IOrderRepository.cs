using System;
using Patterns.Decorator.Repository.Models;

namespace Patterns.Decorator.Repository.Interfaces
{
    public interface IOrderRepository
    {
        public Order Get(Guid id);
    }
}
