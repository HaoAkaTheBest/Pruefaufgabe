using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class LargestPalindromeProduct
    {
        public static long LargestPalindrome(string givenDigits)
        {
            int digits = 0;
            try
            {
                digits = int.Parse(givenDigits);
            }
            catch (System.FormatException)
            {
                throw new Exception(givenDigits + " is not a number or not a valid number for this problem");
            }
            catch (System.OverflowException)
            {
                throw new Exception(givenDigits + " is tooooooo biggggg");
            }
            if (digits < 0) throw new Exception(givenDigits + ": The Number must be bigger than 0");
            if (digits > 5) throw new Exception("The Number is to big, i cant find it");
            if (digits == 1) return 9;
            long max = (int)Math.Pow(10, digits) - 1;
            long min = (int)Math.Pow(10, digits - 1) * 9;
            long result = 0;
            for (long i = max; i >= min; i--)
            {
                for (long j = i; j >= min; j--)
                {
                    long product = i * j;
                    if (IsPalindrome(product) && product > result)
                    {
                        result = product;
                    }
                }
            }
            return result;
        }
        private static bool IsPalindrome(long num)
        {
            string numstring = num.ToString();
            for (int i = 0; i < numstring.Length / 2; i++)
            {
                if (numstring[i] != numstring[numstring.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }       
    }
}
