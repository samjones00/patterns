namespace Patterns.Builder.FuncBuilder
{
    public class FuncOrder
    {
        public string CollectionType { get; set; }
        public string CustomerTelephoneNumber { get; set; }
        public string CustomerName { get; set; }

        public string StoreName { get; set; }

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
