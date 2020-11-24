namespace Patterns.Builder.Conditional
{
    public class ConditionalOrder
    {
        public string CustomerName { get; set; }
        public string StoreName { get; set; }
        public override string ToString()
        {
            return
                $"{nameof(CustomerName)}: {CustomerName}, " +
                $"{nameof(StoreName)}: {StoreName}";
        }
    }
}
