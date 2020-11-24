namespace Patterns.Builder
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
        ConditionalOrder Finish();
    }


    public class ConditionalBuilder:IWithCustomerName,IWithCollectionType,IWithStoreName
    {
        private string CollectionType { get; set; }
        private string CustomerTelephoneNumber { get; set; }
        private string CustomerName { get; set; }
        private string StoreName { get; set; }

        public IWithCustomerName Start()
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

        public IWithCollectionType Package()
        {
            return this;
        }

        public ConditionalOrder Finish()
        {
            return new ConditionalOrder()
            {
                CustomerName = CustomerName,
                StoreName = StoreName
            };
        }
    }
}
