using System;

namespace Patterns.Prototype
{
    public class Person : ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return
                $"{nameof(FirstName)}: {FirstName}, " +
                $"{nameof(LastName)}: {LastName}, " +
                $"{nameof(Address.City)}: {Address.City}";
        }
    }
}
