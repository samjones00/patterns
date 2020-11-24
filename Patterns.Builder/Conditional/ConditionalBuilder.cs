using Patterns.Builder.Models;

namespace Patterns.Builder.Builders
{
    public interface IWithCustomerName
    {
        IWithStoreName AddCustomerName(string customerName);
    }

    public interface IWithStoreName
    {
        IWithCollectionType AddStoreName(string storeName);
    }

    public interface IWithCollectionType
    {
        ConditionalOrder Build();
    }

    public class ConditionalBuilder : IWithCustomerName, IWithCollectionType, IWithStoreName
    {
        private string CustomerName { get; set; }
        private string StoreName { get; set; }

        public IWithCustomerName Init()
        {
            return new ConditionalBuilder();
        }

        public IWithStoreName AddCustomerName(string customerName)
        {
            CustomerName = customerName;
            return this;
        }

        public IWithCollectionType AddStoreName(string storeName)
        {
            StoreName = storeName;
            return this;
        }

        public ConditionalOrder Build()
        {
            return new ConditionalOrder
            {
                CustomerName = CustomerName,
                StoreName = StoreName
            };
        }
    }
}
