using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Validators
{
    public class MaximumLengthValidator : IValidator
    {
        private readonly ValidatorOptions _options;

        public MaximumLengthValidator(ValidatorOptions options)
        {
            _options = options;
        }

        public bool IsValid(string password) => password.Length <= _options.MaximumLength;
    }
}