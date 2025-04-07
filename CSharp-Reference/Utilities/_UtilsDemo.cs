using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static CSharp_Reference.Utilities.StringUtils; // importing static methods
using Xyz = CSharp_Reference.Utilities.NumberUtils; // using namespace alias



namespace CSharp_Reference.Utilities
{
    class _UtilsDemo
    {
        public static void runner()
        {
            Console.WriteLine(UpperCase("pAytOn"));
            Console.WriteLine(StringUtils.LowerCase("PAyToN"));
            
            string res = CSharp_Reference.Utilities.StringUtils.LowerCase("DGKSLKDF"); // using fully qualified name without using statement

            string val = Xyz.removeCommas("23,339.00"); // aliased as Xyz


            
        }
    }
}
