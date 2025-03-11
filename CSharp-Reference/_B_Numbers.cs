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
            Console.WriteLine("\n____Numbers____\n");

            // Order of numeric types (smallest to largest):
            // sbyte < byte < short < ushort < int < uint < long < ulong < float < double < decimal

            // Implicit Casting (smaller to larger type)
            sbyte sb = -128; 
            byte b = 255;
            short s = b;
            ushort us = (ushort)s; // short to ushort (requires explicit cast if negative)
            int i = s; 
            uint ui = (uint)i; // int to uint (requires explicit cast if negative)
            long l = i; 
            ulong ul = (ulong)l; // long to ulong (requires explicit cast if negative)
            float f = l; 
            double d = f; 

            // Explicit Casting (larger to smaller type)
            double largeDouble = 12345.67;
            float smallFloat = (float)largeDouble; 
            long smallLong = (long)smallFloat; 
            int smallInt = (int)smallLong; 
            short smallShort = (short)smallInt; 
            ushort smallUShort = (ushort)smallShort; // short to ushort (may cause overflow)
            byte smallByte = (byte)smallShort; // short to byte (may cause overflow)

            decimal someDecimal = 213.3M;

            // Note: use doubles when accuracy when comparing equality of two numbers is not important.
            // Never compare doubles with ==. The decimal type is accurate and used for money, engineering.
            // 

            // Display values
            Console.WriteLine($"Implicit Casting: {sb} -> {b} -> {s} -> {us} -> {i} -> {ui} -> {l} -> {ul} -> {f} -> {d}");
            Console.WriteLine($"Explicit Casting: {largeDouble} -> {smallFloat} -> {smallLong} -> {smallInt} -> {smallShort} -> {smallUShort} -> {smallByte}");

            // Using Convert class for conversion
            int convertedInt = Convert.ToInt32(3.99); // Rounds the value
            ulong convertedULong = Convert.ToUInt64(4294967295); // Converts to unsigned long

            // Integer types
            int intVal = 42; // 32-bit signed
            uint uintVal = 4294967295; // 32-bit unsigned
            long longVal = 100000L; // 64-bit signed
            ulong ulongVal = 18446744073709551615; // 64-bit unsigned
            short shortVal = 32000; // 16-bit signed
            ushort ushortVal = 65000; // 16-bit unsigned
            byte byteVal = 255; // 8-bit unsigned
            sbyte sbyteVal = -128; // 8-bit signed

            // Floating-point types
            float floatVal = 3.14f; // 32-bit floating-point
            double doubleVal = 3.1415926535; // 64-bit floating-point
            decimal decimalVal = 79.99m; // 128-bit high-precision floating-point

            // Other number operations
            int sum = intVal + 10; // Addition
            double division = doubleVal / 2; // Division
            int remainder = intVal % 5; // Modulus

            // Display results
            Console.WriteLine($"Int: {intVal}, UInt: {uintVal}, Long: {longVal}, ULong: {ulongVal}, Short: {shortVal}, UShort: {ushortVal}, Byte: {byteVal}, SByte: {sbyteVal}");
            Console.WriteLine($"Float: {floatVal}, Double: {doubleVal}, Decimal: {decimalVal}");
            Console.WriteLine($"Sum: {sum}, Division: {division}, Remainder: {remainder}");



            // Parsing strings to numbers

            int parsedInt = int.Parse("123");
            bool tryParseSuccess = int.TryParse("321", out int tryParsedInt);
            Console.WriteLine($"Parsed Int: {parsedInt}, TryParse Success: {tryParseSuccess}, TryParsed Int: {tryParsedInt}");

            string numericString = "123.45";

            int intVal2 = int.Parse(numericString.Split('.')[0]);   // 123 (extract integer part)
            double doubleVal2 = double.Parse(numericString);        // 123.45
            float floatVal2 = float.Parse(numericString);          // 123.45
            decimal decimalVal2 = decimal.Parse(numericString);    // 123.45
            long longVal2 = long.Parse(numericString.Split('.')[0]); // 123 (extract integer part)



            string rowSeparator = new string('-', count: 74);
            Console.WriteLine(rowSeparator);
            Console.WriteLine("Type    Byte(s) of memory               Min                            Max");
            Console.WriteLine(rowSeparator);
            Console.WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            Console.WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            Console.WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            Console.WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            Console.WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            Console.WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            Console.WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            Console.WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            Console.WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            Console.WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            Console.WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            Console.WriteLine(rowSeparator);

        }
    }
}
