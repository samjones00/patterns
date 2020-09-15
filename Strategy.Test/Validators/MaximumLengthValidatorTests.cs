using Patterns.Strategy.Models;
using Patterns.Strategy.Validators;
using Xunit;

namespace Patterns.Strategy.Tests.Validators
{
    public class MaximumLengthValidatorTests
    {
        [Fact]
        public void MaximumLengthValidator_GivenValidLength_ReturnsTrue()
        {
            var validator = new MaximumLengthValidator(new ValidatorOptions(5, 10));

            var password = "abc";
            var isValid = validator.IsValid(password);

            Assert.True(isValid);
        }

        [Fact]
        public void MaximumLengthValidator_GivenInvalidLength_ReturnsFalse()
        {
            var validator = new MaximumLengthValidator(new ValidatorOptions(5, 10));

            var password = "abcdefghijh";
            var isValid = validator.IsValid(password);

            Assert.False(isValid);
        }
    }
}
