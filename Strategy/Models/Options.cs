namespace Patterns.Strategy.Models
{
    public readonly struct ValidatorOptions
    {
        public ValidatorOptions(int minimumLength, int maximumLength)
        {
            MinimumLength = minimumLength;
            MaximumLength = maximumLength;
        }

        public int MinimumLength { get; }
        public int MaximumLength { get; }
    }
}