using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    internal class _F_ConditionalAndLoops
    {
        public static void runner()
        {
            //== If-Else ==================================//
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("Greater than 5");
            }
            else if (num == 5)
            {
                Console.WriteLine("Equal to 5");
            }
            else
            {
                Console.WriteLine("Less than 5");
            }

            //== Switch ==================================//
            char grade = 'B';
            switch (grade)
            {
                case 'A': Console.WriteLine("Excellent"); break;
                case 'B': Console.WriteLine("Good"); goto case 'A'; // example of goto label, 'B' is Excellent 
                case 'C': Console.WriteLine("Average"); goto C_label; // example of another goto label
                default: Console.WriteLine("Fail"); break;
            }

            C_label:
            Console.WriteLine("Needs work");
           

            //== While Loop =============================//
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine($"While: {i}");
                i++;
            }

            //== Do-While Loop ==========================//
            int j = 0;
            do
            {
                Console.WriteLine($"Do-While: {j}");
                j++;
            } while (j < 3);

            //== For Loop ==============================//
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"For: {k}");
            }

            //== Foreach Loop ==========================//
            int[] numbers = { 1, 2, 3 };
            foreach (int n in numbers)
            {
                Console.WriteLine($"Foreach: {n}");
            }
        }
    }
}
