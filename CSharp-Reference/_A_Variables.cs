using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    internal class _A_Variables
    {
        public static void runner()
        {
            Console.WriteLine("\n\n____Variables____\n\n");


            // int 	    4 bytes - Stores whole numbers from -2,147,483,648 to 2,147,483,647
            // long 	8 bytes - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // float 	4 bytes - Stores fractional numbers.Sufficient for storing 6 to 7 decimal digits
            // double   8 bytes - Stores fractional numbers. Sufficient for storing 15 decimal digits
            // bool     1 byte  - Stores true or false values
            // char     2 bytes - Stores a single character/letter, surrounded by single quotes
            // string   2 bytes per character  - Stores a sequence of characters, surrounded by double quotes


            // Type Casting
            //Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            //Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // Explicit Type Casting another way
            //double largeDouble = 12345.67;
            //float smallFloat = (float)largeDouble; // double to float
            //long smallLong = (long)smallFloat;     // float to long
            //int smallInt = (int)smallLong;         // long to int

            // Interpolating strings in C#
            //Console.WriteLine($"Name: {name}, Age: {age}");
            //Console.WriteLine("Name: " + name + ", Age: " + age);
            //Console.WriteLine(string.Format("Name: {0}, Age: {1}", name, age));



            

        }
    }
}
