using Patterns.Factory.Concrete.Interfaces;

namespace Patterns.Factory.Concrete.Models
{
    public class Unicycle: IVehicle
    {
        public string Broadcast => $"Hey, i'm on a {nameof(Unicycle)}";
    }
}
