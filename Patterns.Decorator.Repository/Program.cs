using Patterns.Decorator.Repository.Decorators;
using Patterns.Decorator.Repository.Models;
using System;

namespace Patterns.Decorator.Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order;
            var orderId = new Guid("5d137f6b-8019-4400-8dad-5d74e3bdad51");

            var repository = new OrderRepositoryCacheDecorator();

            //first attempt
            order = repository.Get(orderId);

            //second attempt;
            order = repository.Get(orderId);
        }
    }
}

