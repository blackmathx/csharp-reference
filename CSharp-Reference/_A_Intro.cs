using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Reference
{
    internal class _A_Intro
    {
        public static void runner()
        {
            Console.WriteLine("\n____Intro____\n");

            const string test = "this is a constant value";


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


            // bool        Boolean value                                                               True or False                                                   False
            // byte        8 - bit unsigned integer                                                    0 to 255                                                        0
            // char        16 - bit Unicode character                                                  U + 0000 to U +ffff                                             '\0'
            // decimal     128 - bit precise decimal values with 28 - 29 significant digits            (-7.9 x 1028 to 7.9 x 1028) / 100 to 28                         0.0M
            // double      64 - bit double-precision floating point type                               (+/ -)5.0 x 10 - 324 to(+/ -)1.7 x 10308                        0.0D
            // float       32 - bit single - precision floating point type                             - 3.4 x 1038 to + 3.4 x 1038                                    0.0F
            // int         32 - bit signed integer type                                                - 2,147,483,648 to 2,147,483,647                                0
            // long        64 - bit signed integer type                                                - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807        0L
            // sbyte       8 - bit signed integer type                                                 - 128 to 127                                                    0
            // short       16 - bit signed integer type                                                - 32,768 to 32,767                                              0
            // uint        32 - bit unsigned integer type                                              0 to 4,294,967,295                                              0
            // ulong       64 - bit unsigned integer type                                              0 to 18,446,744,073,709,551,615                                 0
            // ushort      16 - bit unsigned integer type                                              0 to 65,535                                                     0

            // There are 3 built in data types
            // object, string, dynamic

            // A pointer type, example: int* iptr;

            // Nullable types in C# are as follows
            // int? age = null;
            // string? name = null;
            // double? num3 = new double?();
            // double? num4 = 3.14157;
            // bool? boolval = new bool?();

            // Null Coalescing Operator (??). If first is null then it returns second, otherwise returns the first
            // num3 = num1 ?? 5.34; 
            // name = s ?? "Is null";




            // Type Casting
            // Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            // Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            // Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            // Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            // Explicit Type Casting another way
            // double largeDouble = 12345.67;
            // float smallFloat = (float)largeDouble; // double to float
            // long smallLong = (long)smallFloat;     // float to long
            // int smallInt = (int)smallLong;         // long to int


            // Interpolating strings in C#
            // Console.WriteLine($"Name: {name}, Age: {age}");
            // Console.WriteLine("Name: " + name + ", Age: " + age);
            // Console.WriteLine(string.Format("Name: {0}, Age: {1}", name, age));





        }
    }
}
