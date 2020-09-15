using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Validators
{
    public class IsNotEmptyValidator : IValidator
    {
        public IsNotEmptyValidator(ValidatorOptions options)
        {
        }

        public bool IsValid(string password) => !string.IsNullOrEmpty(password);
    }
}
