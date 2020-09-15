using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Validators
{
    public class MinimumLengthValidator : IValidator
    {
        private readonly ValidatorOptions _options;

        public MinimumLengthValidator(ValidatorOptions options)
        {
            _options = options;
        }

        public bool IsValid(string password) => password.Length >= _options.MinimumLength;
    }
}
