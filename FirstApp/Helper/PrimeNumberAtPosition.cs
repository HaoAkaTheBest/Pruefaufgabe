using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class PrimeNumberAtPosition
    {
        public static long PrimeNumberAt(int position)
        {
            List<long> primes = new List<long>();
            primes.Add(2);
            long currentNumber = 3;
            while (primes.Count < position)
            {
                if (isPrime(currentNumber, primes))
                {
                    primes.Add(currentNumber);
                }
                currentNumber += 2;
            }
            return primes.Last();
        }
        private static bool isPrime(long number, List<long> primes)
        {
            foreach (long prime in primes)
            {
                if (number % prime == 0)
                {
                    return false;
                }
            }
            return true;
        }   
    }
}
