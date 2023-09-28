using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class SumSquareDifference
    {
        public static long SumSquareDifferenceOfFirst(string givenNumString)
        {
            int n = 0;
            try
            {
                n = int.Parse(givenNumString);
            }
            catch (System.FormatException)
            {
                throw new Exception(givenNumString + " is not a number or not a valid number for this problem");
            }
            catch (System.OverflowException)
            {
                throw new Exception(givenNumString + " is tooooooo biggggg");
            }

            if(n < 1) throw new Exception(givenNumString + ": The number has to be bigger than 1");
            return squareOfSum(n) - sumOfSquares(n);
        }
        private static long sumOfSquares(int n)
        {
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }
        private static long squareOfSum(int n)
        {
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum * sum;
        }
    }
}
