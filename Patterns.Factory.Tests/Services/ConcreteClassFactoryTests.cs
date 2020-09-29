using Patterns.Factory.Concrete.Factories;
using Patterns.Factory.Concrete.Models;

using Xunit;

namespace Patterns.Factory.Tests.Services
{
    public class ConcreteClassFactoryTests
    {
        [Fact]
        public void Build_ShouldReturn_Unicycle()
        {
            var service = new ConcreteClassFactory();

            var actual = service.Build(1);

            Assert.Contains("Unicycle", actual.Broadcast);
            Assert.IsType<Unicycle>(actual);
        }

        [Fact]
        public void Build_ShouldReturn_Bicycle()
        {
            var service = new ConcreteClassFactory();

            var actual = service.Build(2);

            Assert.Contains("Bicycle", actual.Broadcast);
            Assert.IsType<Bicycle>(actual);
        }

        [Fact]
        public void Build_ShouldReturn_Car()
        {
            var service = new ConcreteClassFactory();

            var actual = service.Build(4);

            Assert.Contains("Car", actual.Broadcast);
            Assert.IsType<Car>(actual);
        }
    }
}
