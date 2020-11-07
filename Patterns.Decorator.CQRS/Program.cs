using System;
using Patterns.Decorator.CQRS.Commands;
using Patterns.Decorator.CQRS.Decorators;
using Patterns.Decorator.CQRS.Repositories;

namespace Patterns.Decorator.CQRS
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderId = Guid.Parse("5d137f6b-8019-4400-8dad-5d74e3bdad51");
            var orderRepository = new OrderRepository();

            var command = new CompleteOrderCommand(orderId);
            var handler = new CompleteOrderCommand.CompleteOrderCommandHandler(orderRepository);

            var decorator = new AuditLoggingDecorator<CompleteOrderCommand>(handler);

            var execute = decorator.Handle(command);
        }
    }
}
