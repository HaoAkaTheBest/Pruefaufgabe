using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class Multipleof3or5Test
    {
        [Theory]
        [InlineData("-2", " is a negative number")]
        [InlineData("-1", " is a negative number")]
        public void Multipleof3or5_WhenGivenNegativeNumber(string givenNum, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => Multipleof3or5.Result(givenNum);

            // Assert
            action.Should().Throw<Exception>().WithMessage(givenNum + isNegative);
        }

        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void Multipleof3or5_WhenGivenAText(string givenNum, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => Multipleof3or5.Result(givenNum);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNum + isNAN);
        }

        [Theory]
        [InlineData("1.2", " is not a number or not a valid number for this problem")]
        [InlineData("2,2", " is not a number or not a valid number for this problem")]
        [InlineData("9,99", " is not a number or not a valid number for this problem")]
        public void Multipleof3or5_WhenGivenFloat(string givenNum, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => Multipleof3or5.Result(givenNum);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNum + isFloat);
        }

        [Theory]
        [InlineData("41000002223", " is tooooooo biggggg")]
        [InlineData("41001231033", " is tooooooo biggggg")]
        [InlineData("41001231022", " is tooooooo biggggg")]
        public void Multipleof3or5_WhenGivenATooBigNumber(string givenNum, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => Multipleof3or5.Result(givenNum);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenNum + tooBig);
        }
    }
}
