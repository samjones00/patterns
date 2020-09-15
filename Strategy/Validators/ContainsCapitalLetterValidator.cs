using System.Linq;
using Patterns.Strategy.Interfaces;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Validators
{
    public class ContainsCapitalLetterValidator : IValidator
    {
        public ContainsCapitalLetterValidator(ValidatorOptions options)
        {
        }
        
        public bool IsValid(string password) => password.ToList().Any(char.IsUpper);
    }
}
