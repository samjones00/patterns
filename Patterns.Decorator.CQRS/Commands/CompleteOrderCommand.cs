using System;
using CSharpFunctionalExtensions;
using Patterns.Decorator.CQRS.Enums;
using Patterns.Decorator.CQRS.Interfaces;

namespace Patterns.Decorator.CQRS.Commands
{
    public sealed class CompleteOrderCommand : ICommand
    {
        private Guid Id { get; }

        public CompleteOrderCommand(Guid id)
        {
            Id = id;
        }

        public sealed class CompleteOrderCommandHandler : ICommandHandler<CompleteOrderCommand>
        {
            private readonly IOrderRepository _repository;

            public CompleteOrderCommandHandler(IOrderRepository repository)
            {
                this._repository = repository;
            }

            public Result Handle(CompleteOrderCommand command)
            {
                var item = _repository.Get(command.Id);
                if (item == null)
                {
                    return Result.Failure($"No Item found with Id: {command.Id}");
                }

                item.Status = OrderStatus.Complete;
                item.CompleteDate = DateTime.UtcNow;

                _repository.Update(item);
                return Result.Success();
            }
        }
    }
}
