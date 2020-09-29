using Patterns.Factory.Concrete.Interfaces;

namespace Patterns.Factory.Concrete.Models
{
    public class Car : IVehicle
    {
        public string Broadcast => $"Hey, i'm in a {nameof(Car)}";
    }
}
