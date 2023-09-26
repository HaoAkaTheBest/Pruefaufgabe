using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class SumSquareDifference
    {
        public static long SumSquareDifferenceOfFirst(int n)
        {
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
