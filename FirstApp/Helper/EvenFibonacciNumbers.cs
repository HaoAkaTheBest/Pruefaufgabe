using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class EvenFibonacciNumbers
    {
        private static List<int> FibonacciGenerator(int max = 4000000)
        {
            List<int> fibonacciNumbers = new List<int>();

            fibonacciNumbers.Add(1);
            fibonacciNumbers.Add(2);
            while(fibonacciNumbers.Last() < max)
            {
                fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2]);
            }
            fibonacciNumbers.Remove(fibonacciNumbers.Last());
            return fibonacciNumbers;
        }

        public static int Sum(int max = 4000000)
        {
            List<int> fibnums = FibonacciGenerator(max);

            int result = 0;
            foreach(int num in fibnums)
            {
                if(IsEven(num))
                {
                    result += num;
                }
            }
            return result;
        }

        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
