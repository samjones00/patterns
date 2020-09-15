using Patterns.Decorator.Interfaces;

namespace Patterns.Decorator
{
    public class BurgerDecorator : IBurgerFilling
    {
        protected IBurgerFilling BurgerFilling;

        public void SetComponent(IBurgerFilling component)
        {
            BurgerFilling = component;
        }

        public virtual void AddFilling()
        {
            BurgerFilling?.AddFilling();
        }
    }
}
