using Patterns.Strategy.Models;
using Patterns.Strategy.Validators;
using Xunit;

namespace Patterns.Strategy.Tests.Validators
{
    public class IsNotEmptyValidatorTests
    {
        [Fact]
        public void IsNotEmptyValidator_GivenString_ReturnsTrue()
        {
            var validator = new IsNotEmptyValidator(new ValidatorOptions(5,10));
            var isValid = validator.IsValid("Abcd");

            Assert.True(isValid);
        }

        [Fact]
        public void IsNotEmptyValidator_GivenEmpty_ReturnsFalse()
        {
            var validator = new IsNotEmptyValidator(new ValidatorOptions(5, 10));
            var isValid = validator.IsValid("");

            Assert.False(isValid);
        }

        [Fact]
        public void IsNotEmptyValidator_GivenNull_ReturnsFalse()
        {
            var validator = new IsNotEmptyValidator(new ValidatorOptions(5, 10));
            var isValid = validator.IsValid(null);

            Assert.False(isValid);
        }
    }
}
