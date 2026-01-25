using Xunit;
using RadixLib;
using System;

namespace RadixLib.Tests
{
    public class RadixTests
    {
       
        [Fact]
        public void Convert_ToBinary_ReturnsCorrect()
        {
            var radix = new Radix(10);

            string result = radix.ConvertDecimalToAnother(2);

            Assert.Equal("1010", result);
        }

  
        [Fact]
        public void Convert_ToOctal_ReturnsCorrect()
        {
            var radix = new Radix(16);

            string result = radix.ConvertDecimalToAnother(8);

            Assert.Equal("20", result);
        }


        [Fact]
        public void Convert_ToHex_ReturnsCorrect()
        {
            var radix = new Radix(255);

            string result = radix.ConvertDecimalToAnother(16);

            Assert.Equal("FF", result);
        }


        [Fact]
        public void Constructor_NegativeNumber_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new Radix(-5)
            );

            Assert.Equal("Incorrect Value", ex.Message);
        }


        [Fact]
        public void Convert_InvalidRadix_LessThan2_ThrowsException()
        {
            var radix = new Radix(10);

            var ex = Assert.Throws<ArgumentException>(
                () => radix.ConvertDecimalToAnother(1)
            );

            Assert.Equal("Invalid Radix", ex.Message);
        }


        [Fact]
        public void Convert_InvalidRadix_GreaterThan16_ThrowsException()
        {
            var radix = new Radix(10);

            var ex = Assert.Throws<ArgumentException>(
                () => radix.ConvertDecimalToAnother(20)
            );

            Assert.Equal("Invalid Radix", ex.Message);
        }
    }
}
