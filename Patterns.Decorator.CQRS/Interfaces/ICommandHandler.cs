using CSharpFunctionalExtensions;

namespace Patterns.Decorator.CQRS.Interfaces
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}
