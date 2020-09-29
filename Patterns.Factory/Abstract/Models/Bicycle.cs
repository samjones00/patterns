namespace Patterns.Factory.Abstract.Models
{
    public class Bicycle : AbstractVehicle
    {
        public override string Broadcast => $"This is a {nameof(Bicycle)}";
    }
}