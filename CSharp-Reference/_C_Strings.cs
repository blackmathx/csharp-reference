using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    internal class _C_Strings
    {
        public static void runner()
        {
            Console.WriteLine("\n\n____Strings____\n\n");


            // Basic string usage
            string greeting = "Hello, World!";
            string name = "Alice";
            string combined = greeting + " My name is " + name + ".";


            // String manipulation
            string upper = greeting.ToUpper();
            string lower = greeting.ToLower();

            string substring = greeting.Substring(7, 5); // "World",, from index 7 and get 5 characters 
            string sub1 = greeting.Substring(7);       // "World!" (from index 7 to end)
            string sub2 = greeting.Substring(0, 5);    // "Hello" (first 5 characters)
            //string sub3 = greeting[7..];               // "World!" (range index)
            //string sub4 = greeting[..5];               // "Hello" (from start to index 5)
            //string sub5 = greeting[7..12];             // "World" (index 7 to 12)
            //string sub6 = greeting[^6..^1];            // "World" (negative index)


            bool containsHello = greeting.Contains("Hello");

            Console.WriteLine($"Upper: {upper}, Lower: {lower}, Substring: {substring}, Contains 'Hello': {containsHello}");

            // Loop through characters in a string
            string word = "Example";
            Console.Write("Characters: ");
            foreach (char c in word)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            // Parsing numbers to strings
            int number = 123;
            double pi = 3.14159;
            string numStr = number.ToString();
            string piStr = pi.ToString("F2"); // Formats to 2 decimal places

            Console.WriteLine($"Number as String: {numStr}, Pi as String: {piStr}");

        }
    }
}
