using Xunit;
using PowerLib;

namespace PowerLib.Tests
{
    public class PowerUtilTests
    {
        // n = 0
        [Fact]
        public void Power_N_Equals_Zero_Returns_One()
        {
            double x = 10.5;
            int n = 0;

            double result = PowerUtil.Power(x, n);

            Assert.Equal(1.0, result);
        }

        // n > 0
        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 2, 25)]
        [InlineData(3, 1, 3)]
        public void Power_N_Positive_Returns_Correct(double x, int n, double expected)
        {
            double result = PowerUtil.Power(x, n);

            Assert.Equal(expected, result, 5);
        }

        // n < 0
        [Theory]
        [InlineData(2, -1, 0.5)]
        [InlineData(2, -2, 0.25)]
        [InlineData(4, -1, 0.25)]
        public void Power_N_Negative_Returns_Correct(double x, int n, double expected)
        {
            double result = PowerUtil.Power(x, n);

            Assert.Equal(expected, result, 5);
        }
    }
}