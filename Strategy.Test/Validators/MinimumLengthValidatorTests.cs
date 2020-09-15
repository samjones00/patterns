using Patterns.Strategy.Models;
using Patterns.Strategy.Validators;
using Xunit;

namespace Patterns.Strategy.Tests.Validators
{
    public class MinimumLengthValidatorTests
    {
        [Fact]
        public void MinimumLengthValidator_GivenValidLength_ReturnsTrue()
        {
            var validator = new MinimumLengthValidator(new ValidatorOptions(5, 10));

            var password = "abcde";
            var isValid = validator.IsValid(password);

            Assert.True(isValid);
        }

        [Fact]
        public void MinimumLengthValidator_GivenInvalidLength_ReturnsFalse()
        {
            var validator = new MinimumLengthValidator(new ValidatorOptions(5, 10));

            var password = "ab";
            var isValid = validator.IsValid(password);

            Assert.False(isValid);
        }
    }
}
