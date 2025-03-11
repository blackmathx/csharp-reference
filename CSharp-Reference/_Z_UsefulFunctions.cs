using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    class _Z_UsefulFunctions
    {
        public static string CardialToOrdinal(int number)
        {
            int lastTwoDigits = number % 100;

            string result;

            switch (lastTwoDigits)
            {
                case 11:
                case 12:
                case 13:
                    result = $"{number:N0}th"; 
                    break;
                default:
                    int lastDigit = number % 10;
                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    result = $"{number:N0}{suffix}";
                    break;
            }
            return result;
        }

        public static int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentException("non negative integers only");
            }
            else if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
