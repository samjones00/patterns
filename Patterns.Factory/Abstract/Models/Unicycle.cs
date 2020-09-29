namespace Patterns.Factory.Abstract.Models
{
    public class Unicycle : AbstractVehicle
    {
        public override string Broadcast => $"This is a {nameof(Unicycle)}";
    }
}
