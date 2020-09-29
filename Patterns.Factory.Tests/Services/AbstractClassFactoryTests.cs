using Patterns.Factory.Abstract.Factories;
using Patterns.Factory.Abstract.Models;
using Xunit;

namespace Patterns.Factory.Tests.Services
{
    public class AbstractClassFactoryTests
    {
        [Fact]
        public void Build_ShouldReturn_Unicycle()
        {
            var service = new AbstractClassFactory();

            var actual = service.Build(1);

            Assert.Contains("Unicycle", actual.Broadcast);
            Assert.IsType<Unicycle>(actual);
        }

        [Fact]
        public void Build_ShouldReturn_Bicycle()
        {
            var service = new AbstractClassFactory();

            var actual = service.Build(2);

            Assert.Contains("Bicycle", actual.Broadcast);
            Assert.IsType<Bicycle>(actual);
        }

        [Fact]
        public void Build_ShouldReturn_Car()
        {
            var service = new AbstractClassFactory();

            var actual = service.Build(4);

            Assert.Contains("Car", actual.Broadcast);
            Assert.IsType<Car>(actual);
        }

        [Fact]
        public void Build_ShouldReturn_Template()
        {
            var service = new AbstractClassFactory();

            var actual = service.Build(0);

            Assert.Contains("incomplete", actual.Broadcast);
            Assert.IsType<IncompleteVehicle>(actual);
        }
    }
}
