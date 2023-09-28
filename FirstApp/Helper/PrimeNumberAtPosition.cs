using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class PrimeNumberAtPosition
    {
        public static long PrimeNumberAt(string positionString)
        {
            int position;
            try
            {
                position = int.Parse(positionString);
            }
            catch (System.FormatException)
            {
                throw new Exception(positionString + " is not a number or not a valid number for this problem");
            }
            catch (System.OverflowException)
            {
                throw new Exception(positionString + " is tooooooo biggggg");
            }

            if(position<1) throw new Exception(positionString + ": Position cannot smaller than 1");
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
