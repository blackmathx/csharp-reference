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
            Console.WriteLine("\n____Strings____\n");


            string greeting = "Hello, World!";

#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string multiLine = """
                "testing"
                  software
                """;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            string name = "Alice";
            string combined1 = greeting + " My name is " + name + ".";
            string combined2 = $"{greeting} My name is {name}.";
            string combined3 = String.Format("Output: {0}, {1}.", greeting, "alice");
            string combined4 = $"{nameof(greeting)} has value {greeting}.";
            //Console.WriteLine(combined4);

            int strLength = name.Length; 


            // String manipulation
            string upper = greeting.ToUpper();
            string lower = greeting.ToLower();

            string substring = greeting.Substring(7, 5); // "World",, from index 7 and get 5 characters 
            string sub1 = greeting.Substring(7);         // "World!" (from index 7 to end)
            string sub2 = greeting.Substring(0, 5);      // "Hello" (first 5 characters)
            string sub3 = greeting[7..];                 // "World!" (range index)
            string sub4 = greeting[..5];                 // "Hello" (from start to index 5)
            string sub5 = greeting[7..12];               // "World" (index 7 to 12)
            string sub6 = greeting[^6..^1];              // "World" (negative index)

            bool containsHello = greeting.Contains("Hello");

            string[] strArray = greeting.Split(',');     // split on , and return a string[]
            int posOf = greeting.IndexOf("!");
            bool eqTest = greeting.Equals("HelloWorld");



            // Static string methods in C#
            /*
            greeting.ToUpper()                                              // string, converts all characters to uppercase
            greeting.ToLower()                                              // string, converts all characters to lowercase
            greeting.Trim()                                                 // string, removes leading and trailing whitespace
            greeting.TrimStart()                                            // string, removes leading whitespace
            greeting.TrimEnd()                                              // string, removes trailing whitespace
            greeting.Replace("World", "C#")                                 // string, replaces a substring with another
            greeting.Substring(0, 5)                                        // string, gets a substring starting from index 0 with length 5
            greeting.Split(',')                                             // string[], splits string by delimiter and returns an array
            greeting.Contains("Hello")                                      // bool, checks if substring exists in the string
            greeting.IndexOf("World")                                       // int, returns the index of the first occurrence of a substring
            greeting.LastIndexOf("o")                                       // int, returns the last index of a character or substring
            greeting.StartsWith("Hello")                                    // bool, checks if the string starts with a substring
            greeting.EndsWith("!")                                          // bool, checks if the string ends with a substring
            greeting.Equals("Hello, World!")                                // bool, compares two strings for equality
            greeting.PadLeft(20)                                            // string, pads the string with spaces on the left to a specified length
            greeting.PadRight(20)                                           // string, pads the string with spaces on the right to a specified length
            string.Concat("Hello", " ", "World!")                           // string, concatenates multiple strings
            string.Join(",", new string[] { "apple", "banana", "cherry" })  // string, joins an array into a single string with delimiter
            string.IsNullOrEmpty("")                                        // bool, checks if the string is null or empty
            string.IsNullOrWhiteSpace(" ")                                  // bool, checks if the string is null, empty, or only whitespace
            string.Compare("a", "b")                                        // int, compares two strings and returns an integer indicating their relative order
            string.Format("Hello, {0}!", "World")                           // string, formats the string with placeholders
            */


            // Parsing numbers to strings
            int number = 123;
            double pi = 3.14159;
            string numStr = number.ToString();
            string piStr = pi.ToString("F2");           // Formats to 2 decimal places
            Console.WriteLine($"Number as String: {numStr}, Pi as String: {piStr}");


            // Loop through characters in a string
            string word = "Example";
            foreach (char c in word)
            {
                Console.Write(c + "-"); 
            }
            Console.WriteLine();


            char[] charArr = "hello".ToCharArray();         // convert a string to char[]
            string backToString = new string (charArr);     // char[] converted to a string. 'new string (chararr)' only works for char[]. 
            char charX = 'x';
            string wasChar = charX.ToString();              // convert a char to string. and 'new string ('a')' does not work for individual chars.
            Console.WriteLine($"result: {charX} and {wasChar}");

            // StringBuilder
            StringBuilder sb = new StringBuilder("start");
            sb.Append("e");
            sb.Append("nd");
            string resultString = sb.ToString();


            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            // Advanced strings

            string something = new('c', count: 24); // expand multiples of a char into a string variable

            #pragma warning disable CS0219 // Variable is assigned but its value is never used
            string somePath = @"C:\test\software\app"; // prepend a @ to specify a literal, otherwise \t is a tab.
            #pragma warning restore CS0219 // Variable is assigned but its value is never used


        }
    }
}
