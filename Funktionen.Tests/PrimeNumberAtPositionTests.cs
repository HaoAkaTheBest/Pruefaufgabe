using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class PrimeNumberAtPositionTests
    {
        [Theory]
        [InlineData("-2", ": Position cannot smaller than 1")]
        [InlineData("-1", ": Position cannot smaller than 1")]
        public void PrimeNumberAtPosition_WhenGivenNegativeValue(string position, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => PrimeNumberAtPosition.PrimeNumberAt(position);

            // Assert
            action.Should().Throw<Exception>().WithMessage(position + isNegative);
        }

        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void PrimeNumberAtPosition_WhenGivenAText(string position, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => PrimeNumberAtPosition.PrimeNumberAt(position);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(position + isNAN);
        }

        [Theory]
        [InlineData("1.2", " is not a number or not a valid number for this problem")]
        [InlineData("2,2", " is not a number or not a valid number for this problem")]
        [InlineData("9,99", " is not a number or not a valid number for this problem")]
        public void PrimeNumberAtPosition_WhenGivenAFloat(string position, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => PrimeNumberAtPosition.PrimeNumberAt(position);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(position + isFloat);
        }

        [Theory]
        [InlineData("41000002223", " is tooooooo biggggg")]
        [InlineData("41001231033", " is tooooooo biggggg")]
        [InlineData("41001231022", " is tooooooo biggggg")]
        public void PrimeNumberAtPosition_WhenGivenATooBigNumber(string position, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => PrimeNumberAtPosition.PrimeNumberAt(position);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(position + tooBig);
        }
    }
}
