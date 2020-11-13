namespace Patterns.Creational.Builder
{
    public class SimpleOrderBuilder
    {
        public string CollectionType { get; set; }
        public string CustomerTelephoneNumber { get; set; }
        public string CustomerName { get; set; }
        public string StoreName { get; set; }

        public SimpleOrder Build()
        {
            return new SimpleOrder(this);
        }

        public SimpleOrderBuilder AddCustomerName(string name)
        {
            CustomerName = name;
            return this;
        }

        public SimpleOrderBuilder AddStoreName(string storeName)
        {
            StoreName = storeName;
            return this;
        }

        public SimpleOrderBuilder AddCustomerTelephoneNumber(string telephoneNumber)
        {
            CustomerTelephoneNumber = telephoneNumber;
            return this;
        }

        public SimpleOrderBuilder AddCollectionType(string collectionType)
        {
            CollectionType = collectionType;
            return this;
        }
    }
}
