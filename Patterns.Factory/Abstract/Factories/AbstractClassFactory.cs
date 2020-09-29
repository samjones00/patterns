using Patterns.Factory.Exceptions;
using Patterns.Factory.Abstract.Models;

namespace Patterns.Factory.Abstract.Factories
{
    public class AbstractClassFactory
    {
       public AbstractVehicle Build(int wheels)
        {
            switch (wheels)
            {
                case 0:
                    return new IncompleteVehicle();
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
