namespace Patterns.Prototype
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
