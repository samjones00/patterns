using System;

namespace Patterns.Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var original = new Person();
            original.FirstName = "Sam";
            original.LastName = "jones";
            original.Address = new Address("London");

            Console.WriteLine("original - " + original);

            var clone = original.Clone() as Person;

            Console.WriteLine("clone without changes - " + clone);

            clone.FirstName = "Bill";
            clone.LastName = "Gates";
            clone.Address = new Address("Somewhere in the US");

            Console.WriteLine("clone with changes - " + clone);
        }
    }
}
