using System;
using Patterns.Builder.Conditional;
using Patterns.Builder.Simple;

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

            var funcBuilder = new FuncBuilder.FuncBuilder();
            funcBuilder.AddCustomerName("customer name");
            funcBuilder.AddStoreName("london");
            var funcOrder = funcBuilder.Build();

            Console.WriteLine(funcOrder);
        }
    }
}
