using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class LargestPrimeFactor
    {
        private static long PollardRho(long n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0) return 2;

            long x = 2, y = 2, d = 1;
            long one = 1;

            Func<long, long> f = num => (num * num + one) % n;

            while (d == 1)
            {
                x = f(x);
                y = f(f(y));
                d = GCD(Math.Abs(x - y), n);
            }
            return d;
        }
        private static long GCD(long a, long b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
            
        }
        private static List<long> PrimeFactors(long n)
        {
            List<long> factors = new List<long>();
            while (n > 1)
            {
                long factor = PollardRho(n);
                factors.Add(factor);
                n /= factor;
            }
            return factors;
        }
        public static long LargestFactor(string givenNumber)
        {
            long n = 0;
            try
            {
                n = long.Parse(givenNumber, CultureInfo.InvariantCulture);
            }
            catch (System.FormatException)
            {
                throw new Exception(givenNumber + " is not a valid number for this Problem or not even a number");
            }
            if (n < 0) throw new Exception(givenNumber + " is a negative number");
            return PrimeFactors(n).Max();
        }
    }
}
