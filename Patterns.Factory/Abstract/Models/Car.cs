namespace Patterns.Factory.Abstract.Models
{
    public class Car : AbstractVehicle
    {
        public override string Broadcast => $"This is a {nameof(Car)}";
    }
}