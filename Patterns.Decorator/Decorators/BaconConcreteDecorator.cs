using System.Diagnostics;

namespace Patterns.Decorator.Decorators
{
    public class BaconConcreteDecorator : BurgerDecorator
    {
        public override void AddFilling()
        {
            base.AddFilling();
            Debug.WriteLine("Added bacon");
        }
    }
}
