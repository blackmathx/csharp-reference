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
            Console.WriteLine("\n____Variables____\n");

            // int        4 bytes  - Stores whole numbers from -2,147,483,648 to 2,147,483,647 (32-bit signed integer)
            // uint       4 bytes  - Stores whole numbers from 0 to 4,294,967,295 (32-bit unsigned integer)
            // long       8 bytes  - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (64-bit signed integer)
            // ulong      8 bytes  - Stores whole numbers from 0 to 18,446,744,073,709,551,615 (64-bit unsigned integer)
            // float      4 bytes  - Stores fractional numbers. Sufficient for storing 6 to 9 decimal digits (32-bit single precision)
            // double     8 bytes  - Stores fractional numbers. Sufficient for storing 15-16 decimal digits (64-bit double precision)
            // decimal    16 bytes - Stores fractional numbers with high precision. Typically used for financial calculations (128-bit)
            // bool       1 byte   - Stores true or false values (often stored as 1 byte, but logically a single bit)
            // char       2 bytes  - Stores a single Unicode character (16-bit, supports all Unicode characters)
            // string     2 bytes per character - Stores a sequence of Unicode characters, surrounded by double quotes (UTF-16 encoding)




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
