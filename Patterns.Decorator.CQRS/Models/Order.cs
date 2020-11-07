using System;
using Patterns.Decorator.CQRS.Enums;

namespace Patterns.Decorator.CQRS.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.New;
        public DateTime CompleteDate { get; set; }
    }
}
