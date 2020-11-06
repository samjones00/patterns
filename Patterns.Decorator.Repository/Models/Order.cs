using System;

namespace Patterns.Decorator.Repository.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}
