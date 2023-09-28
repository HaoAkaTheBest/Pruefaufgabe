using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Helper;
using FluentAssertions;

namespace Funktionen.Tests
{
    public class EvenFibonacci
    {
        [Theory]
        [InlineData("300", 188)]
        [InlineData("4000", 3382)]
        public void Sum_WithCorrectGivenMax(string max, int expected)
        {
            // Arrange
            

            // Act
            var result = EvenFibonacciNumbers.Sum(max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("4100000"," is bigger than 4 Million")]
        [InlineData("410012310", " is bigger than 4 Million")]
        [InlineData("41001231022", " is bigger than 4 Million")]
        public void Sum_WhenMaxValueExceeds4Million(string max, string biggerThanFourMillion)
        {
            // Arrange
           

            // Act
            Action action = () => EvenFibonacciNumbers.Sum(max);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(max + biggerThanFourMillion);
        }

        [Theory]
        [InlineData("-1", ": The Number must be bigger than 0")]
        [InlineData("-90", ": The Number must be bigger than 0")]
        [InlineData("-100", ": The Number must be bigger than 0")]
        public void Sum_WhenMaxValueIsNegative(string max, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => EvenFibonacciNumbers.Sum(max);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(max + isNegative);
        }

        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void Sum_WhenMaxValueIsNAN(string max, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => EvenFibonacciNumbers.Sum(max);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(max + isNAN);
        }

        [Theory]
        [InlineData("1.2", " is not a number or not a valid number for this problem")]
        [InlineData("1,2", " is not a number or not a valid number for this problem")]
        [InlineData("1,3", " is not a number or not a valid number for this problem")]
        public void Sum_WhenMaxValueIsFloat(string max, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => EvenFibonacciNumbers.Sum(max);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(max + isFloat);
        }

    }
}
