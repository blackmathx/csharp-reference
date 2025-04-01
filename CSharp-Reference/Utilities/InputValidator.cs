using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference.Utilities
{
    class InputValidator
    {
        public static bool ValidUsername(string input)
        {
            if (input.StartsWith("1"))
            {
                return false; 
            }
            return true;
        }
    }
}
