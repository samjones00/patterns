using System;
using Patterns.Builder.Builders;

namespace Patterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new SimpleBuilder()
                .AddCustomerName("sam")
                .AddStoreName("london")
                .AddCollectionType("from store")
                .AddCustomerTelephoneNumber("12345 67890")
                .Build();

            Console.WriteLine(order);

            var conditionalOrder = new ConditionalBuilder()
                .Init()
                .AddCustomerName("sam")
                .AddStoreName("london")
                .Build();

            Console.WriteLine(conditionalOrder);
        }
    }
}
