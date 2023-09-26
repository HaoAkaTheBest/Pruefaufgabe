using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class LargestPalindromeProduct
    {
        public static long LargestPalindrome(int digits)
        {
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
