using System.Diagnostics;
using Patterns.Decorator.Decorators;
using Xunit;

namespace Patterns.Decorator.Tests
{
    public class BurgerDecoratorTests
    {
        [Fact]
        public void BurgerDecoratorTests_Example()
        {
            var concreteBurgerComponent = new ConcreteBurgerComponent();
            concreteBurgerComponent.AddFilling();
            Debug.WriteLine(new string('-', 100));

            var cheeseConcreteDecorator = new CheeseConcreteDecorator();
            cheeseConcreteDecorator.SetComponent(concreteBurgerComponent);
            cheeseConcreteDecorator.AddFilling();
            Debug.WriteLine(new string('-', 100));

            var gherkinConcreteDecorator = new GherkinConcreteDecorator();
            gherkinConcreteDecorator.SetComponent(cheeseConcreteDecorator);
            gherkinConcreteDecorator.AddFilling();
            Debug.WriteLine(new string('-', 100));

            var baconDecorator = new BaconConcreteDecorator();
            baconDecorator.SetComponent(gherkinConcreteDecorator);
            baconDecorator.AddFilling();
            Debug.WriteLine(new string('-', 100));
        }
    }
}
