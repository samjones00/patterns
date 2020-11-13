using System;
using System.Runtime.InteropServices;

namespace Patterns.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new SimpleOrderBuilder()
                .AddCustomerName("sam")
                .AddStoreName("london")
                .AddCollectionType("from store")
                .AddCustomerTelephoneNumber("12345 67890")
                .Build();

            var customerName = order.CustomerName;

            var conditionalOrder = new ConditionalBuilder()
                .Start()
                .AddCustomerName("sam")
                .AddStoreName("london")
                .Finish();

            conditionalOrder.CustomerName = "hi";
            
            var storeName = conditionalOrder.StoreName;
        }
    }
}
