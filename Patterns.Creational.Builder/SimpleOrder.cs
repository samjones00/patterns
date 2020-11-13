namespace Patterns.Creational.Builder
{
    public class SimpleOrder
    {
        public string CollectionType { get; set; }
        public string CustomerTelephoneNumber { get; set; }
        public string CustomerName { get; set; }

        public string StoreName { get; set; }

        public SimpleOrder(SimpleOrderBuilder builder)
        {
            CustomerName = builder.CustomerName;
            StoreName = builder.StoreName;
            CollectionType = builder.CollectionType;
            CustomerTelephoneNumber = builder.CustomerTelephoneNumber;
        }
    }
}
