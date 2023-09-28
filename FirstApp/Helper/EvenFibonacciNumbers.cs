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

        public static int Sum(string maxinString = "4000000")
        {
            int max = 0;
            try
            {
                max = int.Parse(maxinString);
            }
            catch (System.OverflowException)
            {
                throw new Exception(maxinString + " is bigger than 4 Million");
            }
            catch(System.FormatException)
            {
                throw new Exception(maxinString + " is not a number or not a valid number for this problem");
            }
            
            if(max > 4000000)
            {
                throw new Exception(max.ToString() + " is bigger than 4 Million");
            }
            if (max < 0)
            {
                throw new Exception(max.ToString() + ": The Number must be bigger than 0");
            }

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
