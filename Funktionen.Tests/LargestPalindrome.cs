using FirstApp.Helper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    public class LargestPalindrome
    {
        [Theory]
        [InlineData("2",9009)]
        [InlineData("1",9)]
        public void LargestPalindrome_WhenGivenRightValue(string givenDigits, int expected)
        {
            // Arrange


            // Act
            var result = LargestPalindromeProduct.LargestPalindrome(givenDigits);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("-2", ": The Number must be bigger than 0")]
        [InlineData("-1", ": The Number must be bigger than 0")]
        public void LargestPalindrome_WhenGivenNegativeValue(string givenDigits, string isNegative)
        {
            // Arrange


            // Act
            Action action = () => LargestPalindromeProduct.LargestPalindrome(givenDigits);

            // Assert
            action.Should().Throw<Exception>().WithMessage(givenDigits + isNegative);
        }

        [Theory]
        [InlineData("6", "The Number is to big, i cant find it")]
        [InlineData("10", "The Number is to big, i cant find it")]
        public void LargestPalindrome_WhenGivenBiggerThanFive(string givenDigits, string isBiggerThanFive)
        {
            // Arrange


            // Act
            Action action = () => LargestPalindromeProduct.LargestPalindrome(givenDigits);

            // Assert
            action.Should().Throw<Exception>().WithMessage(isBiggerThanFive);
        }

        [Theory]
        [InlineData("data", " is not a number or not a valid number for this problem")]
        [InlineData("fourmilion", " is not a number or not a valid number for this problem")]
        [InlineData("hehehe", " is not a number or not a valid number for this problem")]
        public void LargestPalindrome_WhenGivenAText(string givenDigits, string isNAN)
        {
            // Arrange


            // Act
            Action action = () => LargestPalindromeProduct.LargestPalindrome(givenDigits);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenDigits + isNAN);
        }

        [Theory]
        [InlineData("1.2", " is not a number or not a valid number for this problem")]
        [InlineData("2,2", " is not a number or not a valid number for this problem")]
        [InlineData("9,99", " is not a number or not a valid number for this problem")]
        public void LargestPalindrome_WhenGivenAFloat(string givenDigits, string isFloat)
        {
            // Arrange


            // Act
            Action action = () => LargestPalindromeProduct.LargestPalindrome(givenDigits);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenDigits + isFloat);
        }

        [Theory]
        [InlineData("41000002223", " is tooooooo biggggg")]
        [InlineData("41001231033", " is tooooooo biggggg")]
        [InlineData("41001231022", " is tooooooo biggggg")]
        public void LargestPalindrome_WhenGivenATooBigNumber(string givenDigits, string tooBig)
        {
            // Arrange


            // Act
            Action action = () => LargestPalindromeProduct.LargestPalindrome(givenDigits);

            // Assert
            action.Should().Throw<Exception>()
                .WithMessage(givenDigits + tooBig);
        }
    }
}
