using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference.Utilities
{
    class StringUtils
    {
        public static String UpperCase(string input)
        {
            return input.ToUpper();
        }

        public static String LowerCase(string input)
        {
            return input.ToLower();
        }

        public static String MixedCase(string input)
        {
            // TODO return mixed case
            return input;
        }

        public static String ReverseCase(string input)
        {
            // TODO implement
            return "";
        }
    }
}
