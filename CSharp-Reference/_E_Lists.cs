using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    internal class _E_Lists
    {
        public static void runner()
        {
            //== List Declaration and Initialization ===========================//

            List<int> list10 = new List<int>(); // empty list
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 }; // List with initial values
            List<int> intListAlt = new() { 2, 4, 5, 1 };
            List<string> stringList = new List<string>(); // Empty List of strings
            stringList.Add("Apple"); 
            stringList.Add("Banana");
            stringList.Remove("Apple");

            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }
            Console.WriteLine($"First element in intList: {intList[0]}"); // Access by index
            Console.WriteLine($"Second element in stringList: {stringList[1]}");

            //== Iterating through List ========================================//

            Console.WriteLine("Iterating through intList:");
            foreach (var item in intList)
            {
                Console.Write(item + " "); // Print each element
            }
            Console.WriteLine();

            //== Adding/Removing Elements =====================================//

            intList.Add(6); // Add element at the end
            stringList.Insert(1, "Cherry"); // Insert element at specific index
            stringList.Remove("Banana"); // Remove by value
            intList.RemoveAt(2); // Remove by index


            //== Searching for Elements ========================================//
            bool exists = intList.Contains(4); // Check if the list contains a value
            Console.WriteLine($"Does intList contain 4? {exists}");

            int index = stringList.IndexOf("Cherry"); // Find index of specific element
            Console.WriteLine($"Index of 'Cherry' in stringList: {index}");

            //== Sorting Lists ================================================//
            List<int> unsortedList = new List<int> { 10, 5, 8, 1, 3 };
            unsortedList.Sort(); // Sort the list in ascending order

            //== Reversing a List =============================================//
            unsortedList.Reverse(); // Reverse the list

            //== Other Useful Methods =========================================//
            intList.Clear(); // Clear all elements from the list

            //== Static Methods ===============================================//
            List<int> copiedList = new List<int>(intList); // Copy constructor
            Console.WriteLine($"Copied List Count: {copiedList.Count}");

            List<int> rangeList = new List<int>(); // List from range of values
            rangeList.AddRange(new int[] { 7, 8, 9 });
            Console.WriteLine("List after AddRange: ");
            foreach (var item in rangeList)
            {
                Console.Write(item + " "); // Print after AddRange
            }
            Console.WriteLine();

            //== Converting List to Array =====================================//
            int[] arrayFromList = intList.ToArray(); // Convert List to Array
            Console.WriteLine("Array from List: ");
            foreach (var item in arrayFromList)
            {
                Console.Write(item + " "); // Print array elements
            }
            Console.WriteLine();
        }
    }
}
