using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Creational.Prototype
{
    public class Address
    {
       public string Line1 { get; set; }
       public string City { get; set; }

       public Address(string city)
       {
           City = city;
       }
    }
}
