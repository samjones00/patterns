using Patterns.Factory.Concrete.Interfaces;
using Patterns.Factory.Concrete.Models;
using Patterns.Factory.Exceptions;

namespace Patterns.Factory.Concrete.Factories
{
    public class ConcreteClassFactory
    {
        public IVehicle Build(int wheels)
        {
            switch (wheels)
            {
                case 1:
                    return new Unicycle();
                case 2:
                    return new Bicycle();
                case 4:
                    return new Car();
                default:
                    throw new VehicleNotSupportedException();
            }
        }
    }
}