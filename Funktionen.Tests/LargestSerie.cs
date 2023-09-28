using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class LargestSerie
    {
        [Theory]
        [InlineData("-2", ": Number has to be bigger than 0")]
        [InlineData("-1", ": Number has to be bigger than 0")]
        public void LargestProductInASerie_WhenGivenNegativeValue(string givenLength, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => LargestProductInASeries.LargestProduct(givenLength);

            // Assert
            action.Should().Throw<Exception>().WithMessage(givenLength + isNegative);
        }

        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void LargestProductInASerie_WhenGivenAText(string givenLength, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => LargestProductInASeries.LargestProduct(givenLength);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenLength + isNAN);
        }

        [Theory]
        [InlineData("2,4", " is not a number or not a valid number for this problem")]
        [InlineData("1.5", " is not a number or not a valid number for this problem")]
        [InlineData("0.9", " is not a number or not a valid number for this problem")]
        public void LargestProductInASerie_WhenGivenAFloat(string givenLength, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => LargestProductInASeries.LargestProduct(givenLength);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenLength + isFloat);
        }

        [Theory]
        [InlineData("41000002223", " is tooooooo biggggg")]
        [InlineData("41001231033", " is tooooooo biggggg")]
        [InlineData("41001231022", " is tooooooo biggggg")]
        public void LargestProductInASerie_WhenGivenTooBigNumber(string givenLength, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => LargestProductInASeries.LargestProduct(givenLength);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenLength + tooBig);
        }

        [Theory]
        [InlineData("3000", "The Serie is only 1000-digit long")]
        [InlineData("2000", "The Serie is only 1000-digit long")]
        [InlineData("1002", "The Serie is only 1000-digit long")]
        public void LargestProductInASerie_WhenGivenBiggerThan1000(string givenLength, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => LargestProductInASeries.LargestProduct(givenLength);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(tooBig);
        }
    }
}
