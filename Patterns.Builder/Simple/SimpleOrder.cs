using Patterns.Builder.Builders;

namespace Patterns.Builder.Models
{
    public class SimpleOrder
    {
        public string CollectionType { get; }
        public string CustomerTelephoneNumber { get; }
        public string CustomerName { get; }

        public string StoreName { get; }

        public SimpleOrder(SimpleBuilder builder)
        {
            CustomerName = builder.CustomerName;
            StoreName = builder.StoreName;
            CollectionType = builder.CollectionType;
            CustomerTelephoneNumber = builder.CustomerTelephoneNumber;
        }

        public override string ToString()
        {
            return
                $"{nameof(CustomerName)}: {CustomerName}, " +
                $"{nameof(StoreName)}: {StoreName}, " +
                $"{nameof(CollectionType)}: {CollectionType}, " +
                $"{nameof(CustomerTelephoneNumber)}: {CustomerTelephoneNumber}";
        }
    }
}
