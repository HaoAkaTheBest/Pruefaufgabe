using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Helper
{
    public class Multipleof3or5
    {
        public static int Result(string givennumString)
        {
            int givennum = 0;
            try
            {
                givennum = int.Parse(givennumString);
            }
            catch (System.FormatException)
            {
                throw new Exception(givennumString + " is not a number or not a valid number for this problem");
            }
            catch (System.OverflowException)
            {
                throw new Exception(givennumString + " is tooooooo biggggg");
            }
            

            if(givennum<0) throw new Exception(givennumString + " is a negative number");
            int result = 0;
            for (int num = 0; num < givennum; num++)
            {
                if (IsMultipleof3(num) || IsMultipleof5(num))
                {
                    result += num;
                }
            }
            return result;
        }
        private static bool IsMultipleof3(int number)
        {
            return number % 3 == 0;
        }
        private static bool IsMultipleof5(int number)
        {
            return number % 5 == 0;
        }
    }
}

