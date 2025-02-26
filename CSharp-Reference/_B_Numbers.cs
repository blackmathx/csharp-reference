using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    internal class _B_Numbers
    {
        public static void runner()
        {
            Console.WriteLine("\n\n____Numbers____\n\n");


            // Order of numeric types (smallest to largest):
            // byte < short < int < long < float < double < decimal

            // Implicit Casting (smaller to larger type)
            byte b = 255;
            short s = b;  // byte to short
            int i = s;    // short to int
            long l = i;   // int to long
            float f = l;  // long to float
            double d = f; // float to double

            // Explicit Casting (larger to smaller type)
            double largeDouble = 12345.67;
            float smallFloat = (float)largeDouble; // double to float
            long smallLong = (long)smallFloat;     // float to long
            int smallInt = (int)smallLong;         // long to int
            short smallShort = (short)smallInt;    // int to short
            byte smallByte = (byte)smallShort;     // short to byte

            // Display values
            Console.WriteLine($"Implicit Casting: {b} -> {s} -> {i} -> {l} -> {f} -> {d}");
            Console.WriteLine($"Explicit Casting: {largeDouble} -> {smallFloat} -> {smallLong} -> {smallInt} -> {smallShort} -> {smallByte}");

            // Using Convert class for conversion
            int convertedInt = Convert.ToInt32(3.99); // Rounds the value



            // Integer types
            int intVal = 42;
            long longVal = 100000L;
            short shortVal = 32000;
            byte byteVal = 255;

            // Floating-point types
            float floatVal = 3.14f;
            double doubleVal = 3.1415926535;
            decimal decimalVal = 79.99m; // High-precision for financial calculations

            // Other number operations
            int sum = intVal + 10;
            double division = doubleVal / 2;
            int remainder = intVal % 5;


            Console.WriteLine($"Int: {intVal}, Long: {longVal}, Short: {shortVal}, Byte: {byteVal}");
            Console.WriteLine($"Float: {floatVal}, Double: {doubleVal}, Decimal: {decimalVal}");
            Console.WriteLine($"Sum: {sum}, Division: {division}, Remainder: {remainder}");


            // Parsing strings to numbers
            int parsedInt = int.Parse("123");
            bool tryParseSuccess = int.TryParse("456", out int tryParsedInt);

            Console.WriteLine($"Parsed Int: {parsedInt}, TryParse Success: {tryParseSuccess}, TryParsed Int: {tryParsedInt}");


        }
    }
}
