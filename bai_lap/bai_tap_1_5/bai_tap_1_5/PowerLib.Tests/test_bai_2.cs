using Xunit;
using PolynomialLib;
using System;
using System.Collections.Generic;

namespace PolynomialLib.Tests
{
    public class PolynomialTests
    {
    
        [Fact]
        public void Cal_ValidPolynomial_ReturnsCorrectValue()
        {
  
            int n = 2;
            var a = new List<int> { 1, 2, 3 };
            var poly = new Polynomial(n, a);

            int result = poly.Cal(2); 

            Assert.Equal(17, result);
        }


        [Fact]
        public void Constructor_NegativeDegree_ThrowsException()
        {
            var a = new List<int> { 1, 2 };

            var ex = Assert.Throws<ArgumentException>(
                () => new Polynomial(-1, a)
            );

            Assert.Equal("Invalid Data", ex.Message);
        }


        [Fact]
        public void Constructor_NotEnoughCoefficients_ThrowsException()
        {
            int n = 3;
            var a = new List<int> { 1, 2, 3 }; // thiếu 1 hệ số

            var ex = Assert.Throws<ArgumentException>(
                () => new Polynomial(n, a)
            );

            Assert.Equal("Invalid Data", ex.Message);
        }


        [Fact]
        public void Constructor_TooManyCoefficients_ThrowsException()
        {
            int n = 1;
            var a = new List<int> { 1, 2, 3 };

            var ex = Assert.Throws<ArgumentException>(
                () => new Polynomial(n, a)
            );

            Assert.Equal("Invalid Data", ex.Message);
        }
    }
}