using System.Diagnostics;

namespace Patterns.Decorator.Decorators
{
    public class GherkinConcreteDecorator : BurgerDecorator
    {
        public override void AddFilling()
        {
            base.AddFilling();
            Debug.WriteLine("Added gherkin");
        }
    }
}