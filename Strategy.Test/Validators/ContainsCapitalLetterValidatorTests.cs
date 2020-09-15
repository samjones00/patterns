using Patterns.Strategy.Models;
using Patterns.Strategy.Validators;
using Xunit;

namespace Patterns.Strategy.Tests.Validators
{
   public class ContainsCapitalLetterValidatorTests
    {
        [Fact]
        public void ContainsCapitalLetterValidator_GivenStringContainingCapitalLetter_ReturnsTrue()
        {
            var validator = new ContainsCapitalLetterValidator(new ValidatorOptions(5, 10));
            var password = "Abcd";

            var isValid = validator.IsValid(password);

            Assert.True(isValid);
        }

        [Fact]
        public void ContainsCapitalLetterValidator_GivenStringExcludingCapitalLetter_ReturnsFalse()
        {
            var validator = new ContainsCapitalLetterValidator(new ValidatorOptions(5, 10));
            var password = "abcd";

            var isValid = validator.IsValid(password);

            Assert.False(isValid);
        }
    }
}
