using System;

namespace Patterns.Singleton
{
    public class SingletonClass
    {
        public DateTime DateInitiated = DateTime.Now;

        public void DoAction()
        {
            Console.WriteLine($"Date initiated: {DateInitiated}");
        }
    }
}
