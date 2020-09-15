using Xunit;

namespace Patterns.Strategy.Tests
{
    public class ValidatorServiceTests
    {
        [Fact]
        public void IsValid_GivenShortString_ReturnsFalse()
        {
            var validator = new ValidatorService();

            var password = "abc";
            var isValid = validator.IsValid(password);

            Assert.False(isValid);
        }

        [Fact]
        public void IsValid_GivenLongString_ReturnsFalse()
        {
            var validator = new ValidatorService();

            var password = "abcdefghijklmn";
            var isValid = validator.IsValid(password);

            Assert.False(isValid);
        }

        [Fact]
        public void IsValid_GivenValidLengthAllLowerCaseString_ReturnsFalse()
        {
            var validator = new ValidatorService();

            var password = "abcd";
            var isValid = validator.IsValid(password);

            Assert.False(isValid);
        }

        [Fact]
        public void IsValid_GivenValidString_ReturnsTrue()
        {
            var validator = new ValidatorService();

            var password = "Abcde";
            var isValid = validator.IsValid(password);

            Assert.True(isValid);
        }
    }
}
