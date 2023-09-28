using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class SmallestMultipleTests
    {
        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void SmallestMultiple_WhenGivenAText(string maxDivisor, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => SmallestMultiple.SmallestMult(maxDivisor);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(maxDivisor + isNAN);
        }

        [Theory]
        [InlineData("1.2", " is not a number or not a valid number for this problem")]
        [InlineData("2,2", " is not a number or not a valid number for this problem")]
        [InlineData("9,99", " is not a number or not a valid number for this problem")]
        public void SmallestMultiple_WhenGivenAFloat(string maxDivisor, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => SmallestMultiple.SmallestMult(maxDivisor);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(maxDivisor + isFloat);
        }

        [Theory]
        [InlineData("41000002223", " is tooooooo biggggg")]
        [InlineData("41001231033", " is tooooooo biggggg")]
        [InlineData("41001231022", " is tooooooo biggggg")]
        public void SmallestMultiple_WhenGivenATooBigNumber(string maxDivisor, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => SmallestMultiple.SmallestMult(maxDivisor);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(maxDivisor + tooBig);
        }

        [Theory]
        [InlineData("-2", ": The number has to be bigger than 1")]
        [InlineData("-1", ": The number has to be bigger than 1")]
        public void SmallestMultiple_WhenGivenNegativeValue(string maxDivisor, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => SmallestMultiple.SmallestMult(maxDivisor);

            // Assert
            action.Should().Throw<Exception>().WithMessage(maxDivisor + isNegative);
        }
    }
}
