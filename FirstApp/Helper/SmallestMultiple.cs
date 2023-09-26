using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class SmallestMultiple
    {
        public static long SmallestMult(int maxDivisor)
        {
            List<long> divisors = new List<long>();
            for (int i = 1; i <= maxDivisor; i++)
            {
                divisors.Add(i);
            }
            return LCM(divisors,0);
        }
        private static long GCD(long a, long b)
        {
            if(a>b)
            {
                if (b == 0) return a;
                return GCD(b, a % b);
            }
            else
            {
                if (a == 0) return b;
                return GCD(a, b % a);
            }
            

        }
        private static long LCM(List<long> numbers, int currentIndex)
        {
            if (currentIndex == numbers.Count - 1)
                return numbers[currentIndex];

            long currentNumber = numbers[currentIndex];
            long nextLCM = LCM(numbers, currentIndex + 1);

            return (currentNumber / GCD(currentNumber, nextLCM)) * nextLCM;
        }

    }
}
