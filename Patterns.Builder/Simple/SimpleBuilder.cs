using Patterns.Builder.Models;

namespace Patterns.Builder.Builders
{
    public class SimpleBuilder
    {
        public string CollectionType { get; set;}
        public string CustomerTelephoneNumber { get; set; }
        public string CustomerName { get; set; }
        public string StoreName { get; set; }

        public SimpleOrder Build()
        {
            return new SimpleOrder(this);
        }

        public SimpleBuilder AddCustomerName(string name)
        {
            CustomerName = name;
            return this;
        }

        public SimpleBuilder AddStoreName(string storeName)
        {
            StoreName = storeName;
            return this;
        }

        public SimpleBuilder AddCustomerTelephoneNumber(string telephoneNumber)
        {
            CustomerTelephoneNumber = telephoneNumber;
            return this;
        }

        public SimpleBuilder AddCollectionType(string collectionType)
        {
            CollectionType = collectionType;
            return this;
        }
    }
}
