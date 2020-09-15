using System.Diagnostics;

namespace Patterns.Decorator.Decorators
{
    public class CheeseConcreteDecorator : BurgerDecorator
    {
        public override void AddFilling()
        {
            base.AddFilling();
            Debug.WriteLine("Added cheese");
        }
    }
}
