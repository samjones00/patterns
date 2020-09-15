using System.Diagnostics;
using Patterns.Decorator.Interfaces;

namespace Patterns.Decorator
{
    public class ConcreteBurgerComponent : IBurgerFilling
    {
        public void AddFilling()
        {
            Debug.WriteLine("Added burger bun");
        }
    }
}
