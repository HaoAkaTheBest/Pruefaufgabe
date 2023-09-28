using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class SumSquareDifferenceTests
    {
        [Theory]
        [InlineData("-2", ": The number has to be bigger than 1")]
        [InlineData("-1", ": The number has to be bigger than 1")]
        public void SumSquareDifference_WhenGivenSmallerThan1(string givenNum, string isSmaller1)
        {
            // Arrange


            // Act
            Action action = () => SumSquareDifference.SumSquareDifferenceOfFirst(givenNum);

            // Assert
            action.Should().Throw<Exception>().WithMessage(givenNum + isSmaller1);
        }

        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void SumSquareDifference_WhenGivenAText(string givenNum, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => SumSquareDifference.SumSquareDifferenceOfFirst(givenNum);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNum + isNAN);
        }

        [Theory]
        [InlineData("1.2", " is not a number or not a valid number for this problem")]
        [InlineData("2,2", " is not a number or not a valid number for this problem")]
        [InlineData("9,99", " is not a number or not a valid number for this problem")]
        public void SumSquareDifference_WhenGivenAFloat(string givenNum, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => SumSquareDifference.SumSquareDifferenceOfFirst(givenNum);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNum + isFloat);
        }

        [Theory]
        [InlineData("41000002223", " is tooooooo biggggg")]
        [InlineData("41001231033", " is tooooooo biggggg")]
        [InlineData("41001231022", " is tooooooo biggggg")]
        public void SumSquareDifference_WhenGivenATooBigNumber(string givenNum, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => SumSquareDifference.SumSquareDifferenceOfFirst(givenNum);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNum + tooBig);
        }
    }
}
