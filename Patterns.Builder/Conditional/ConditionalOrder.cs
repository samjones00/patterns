namespace Patterns.Builder.Models
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
