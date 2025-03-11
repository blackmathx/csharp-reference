using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    class _Z_ExampleOne
    {
        public static void runner()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(
                    enumType: typeof(ConsoleColor),
                    value: "red",
                    ignoreCase: true);

            Console.BackgroundColor = (ConsoleColor)Enum.Parse(
                    enumType: typeof(ConsoleColor),
                    value: "yellow",
                    ignoreCase: true);


            if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
            {
                Console.WriteLine("Windows 10 or later");
            }
            else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
            {
                Console.WriteLine("iOS 14.5 or later");
            }
            else
            {
                Console.WriteLine("Not Supported");
            }


        }




    }
}
