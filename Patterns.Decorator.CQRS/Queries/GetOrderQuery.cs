using System.Collections.Generic;
using System.Linq;
using Patterns.Decorator.CQRS.Enums;
using Patterns.Decorator.CQRS.Interfaces;
using Patterns.Decorator.CQRS.Models;

namespace Patterns.Decorator.CQRS.Queries
{
    public class GetOrderQuery : IQuery<List<Order>>
    {
        public bool CompletedOnly { get; set; }

        public GetOrderQuery(bool completedOnly = false)
        {
            CompletedOnly = completedOnly;
        }

        public sealed class GetOrderQueryHandler : IQueryHandler<GetOrderQuery, List<Order>>
        {
            private readonly IOrderRepository _repository;

            public GetOrderQueryHandler(IOrderRepository repository)
            {
                this._repository = repository;
            }

            public List<Order> Handle(GetOrderQuery query)
            {
                var items = _repository.Get();
                if (query.CompletedOnly)
                {
                    items.Where(i => i.Status == OrderStatus.Complete);
                }

                return items.ToList();
            }
        }
    }
}
