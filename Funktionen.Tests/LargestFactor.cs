using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class LargestFactor
    {
        [Theory]
        [InlineData("-2", " is a negative number")]
        [InlineData("-1", " is a negative number")]
        public void LargestFactor_WhenGivenNegativeNumber(string givenNumber, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => LargestPrimeFactor.LargestFactor(givenNumber);

            // Assert
            action.Should().Throw<Exception>().WithMessage(givenNumber + isNegative);
        }

        [Theory]
        [InlineData("data", " is not a valid number for this Problem or not even a number")]
        [InlineData("fourmilion", " is not a valid number for this Problem or not even a number")]
        [InlineData("hehehe", " is not a valid number for this Problem or not even a number")]
        public void LargestFactor_WhenGivenAText(string givenNumber, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => LargestPrimeFactor.LargestFactor(givenNumber);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNumber + isNAN);
        }

        [Theory]
        [InlineData("1.1", " is not a valid number for this Problem or not even a number")]
        [InlineData("1.3", " is not a valid number for this Problem or not even a number")]
        [InlineData("1.5", " is not a valid number for this Problem or not even a number")]
        public void LargestFactor_WhenGivenAFloat(string givenNumber, string isNAWN)
        {
            // Arrange


            // Act
            Action action = () => LargestPrimeFactor.LargestFactor(givenNumber);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNumber + isNAWN);
        }
    }
}
