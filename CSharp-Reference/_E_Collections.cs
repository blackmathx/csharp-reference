using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Reference
{
    internal class _E_Collections
    {
        public static void runner()
        {

            /*
            

            Examples here include:
               List
               ArrayList
               Dictionary
               Queue
               HashSet
               Hashtable
             
              
            There are several other collections in C#. Here are some more:
          
                Generic Collections(System.Collections.Generic)
                    Stack < T > – LIFO(Last - In - First - Out) collection.
                    SortedList < TKey, TValue > – Sorted key-value pairs.
                    SortedDictionary < TKey, TValue > – Like Dictionary, but keeps keys sorted.
                    LinkedList < T > – Doubly linked list.

                Non - Generic Collections(System.Collections)
                    Stack – Non - generic version of Stack<T>.
                    SortedList – Non - generic key - value pair collection.

                Concurrent Collections(System.Collections.Concurrent)
                    ConcurrentBag < T > – Thread - safe unordered collection.
                    ConcurrentQueue < T > – Thread - safe FIFO queue.
                    ConcurrentStack < T > – Thread - safe LIFO stack.
                    ConcurrentDictionary < TKey, TValue > – Thread - safe key - value pair collection.

                Immutable Collections(System.Collections.Immutable)
                    ImmutableList < T > – Read - only, thread - safe list.
                    ImmutableDictionary < TKey, TValue > – Read - only, thread - safe dictionary.
                    ImmutableHashSet < T > – Read - only, thread - safe hash set.
                    ImmutableArray < T > – Read - only, fixed-size array.
                    ImmutableQueue < T > – Read - only, thread - safe queue.
                    ImmutableStack < T > – Read - only, thread - safe stack.

            */





            // List<T>
            //-----------------------------------------------------------------------
            List<int> list10 = new List<int>();                     // empty list
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };    // List with initial values
            List<int> intListAlt = new() { 2, 4, 5, 1 };
            List<string> stringList = new List<string>();           // Empty List of strings

            stringList.Add("Apple");
            stringList.Add("Banana");
            stringList.Remove("Apple");



            // ArrayList<T>
            //-----------------------------------------------------------------------
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add(2);
            myArrayList.Add(3);
            myArrayList.Remove(3);
            bool bContains = myArrayList.Contains(2);
            foreach(object obj in myArrayList) Console.WriteLine(obj);

            // Add(2);
            // Remove(2);
            // RemoveAt(index);
            // Reverse();
            // Sort();
            // ToArray();
            // Clear();



            // Dictionary<TKey, TValue>
            //-----------------------------------------------------------------------
            Dictionary<string, string> states = new Dictionary<string, string>();
            states.Add("CA", "California");
            states.Add("TX", "Texas");
            states.Add("NY", "New York");
            bool exists = states.ContainsKey("TX");
            string? value200;
            states.TryGetValue("NY", out value200 );
            Console.WriteLine($"this working? {value200}");

            foreach (var state in states)
            {
                Console.WriteLine($"{state.Key}: {state.Value}");
            }

            var states2 = new Dictionary<string, string>()
            {
                {"CA","California" },
                {"TX","Texas" },
                {"NY", "New York" }
            };
            Console.WriteLine(states["CA"]);
            Console.WriteLine(states["NY"]);



            // Queue<T>
            //-----------------------------------------------------------------------
            var queue = new Queue<string>();
            queue.Enqueue("John");
            queue.Enqueue("Alice");
            string output = queue.Dequeue();
            int count = queue.Count;



            // HashSet<T>
            //-----------------------------------------------------------------------
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(2);
            hs.Remove(2);
            hs.Contains(1);
            hs.Clear();



            // Hashtable
            //-----------------------------------------------------------------------
            Hashtable ht = new Hashtable();
            ht.Add("001", "Mark Ali");
            ht.Add("003", "Joe Honer");
            ht.Add("004", "Joel Herms");
            ht.Remove("004");
            bool tf = ht.Contains("003");
            ht.Clear();



            // SortedList<TKey, TValue>
            //-----------------------------------------------------------------------
            var sortedList = new SortedList<int, string>();
            sortedList.Add(2, "Second");
            sortedList.Add(1, "First");
            sortedList.Add(3, "Third");


            var sortedList2 = new SortedList<int, string>
            {
                { 2, "Second" }, { 1, "First" }, { 3, "Third" }
            };

            sortedList2[1] = "Updated";   
            sortedList2.Remove(2);             
            bool hasKey = sortedList2.ContainsKey(1);
            bool hasValue = sortedList2.ContainsValue("Third");
            int keyIndex = sortedList2.IndexOfKey(3);
            int valueIndex = sortedList2.IndexOfValue("Updated");


            foreach (var item in sortedList2)
                Console.WriteLine($"{item.Key}: {item.Value}");


            sortedList2.Clear();





            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            // Old examples of List only
            // TODO: move or remove.




            List<int> list100 = new List<int>();                     // empty list
            List<int> intList0 = new List<int> { 1, 2, 3, 4, 5 };    // List with initial values
            List<int> intListAlt0 = new() { 2, 4, 5, 1 };
            List<string> stringList0 = new List<string>();           // Empty List of strings

            stringList0.Add("Apple"); 
            stringList0.Add("Banana");
            stringList0.Remove("Apple");


            // Iterating through lists
            //-------------------------------------------------------
            foreach (string str in stringList0)
            {
                Console.WriteLine(str);
            }
            for (int i = 0; i < stringList0.Count; i++)
            {
                Console.WriteLine(stringList0[i]);
            }

            Console.WriteLine($"First element in intList0: {intList0[0]}"); // Access by index
            Console.WriteLine($"Second element in stringLis0t: {stringList0[0]}");

            Console.WriteLine("Iterating through intList:");

            foreach (var item in intList0)
            {
                Console.Write(item + " "); // Print each element
            }
            Console.WriteLine();



            // List methods
            //-------------------------------------------------------------------


            //== Adding/Removing Elements =====================================

            intList0.Add(6);                     // Add element at the end
            stringList0.Insert(1, "Cherry");     // Insert element at specific index
            stringList0.Remove("Banana");        // Remove by value
            intList0.RemoveAt(2);                // Remove by index


            //== Searching for Elements ========================================
            bool exists0 = intList0.Contains(4);  // Check if the list contains a value
            Console.WriteLine($"Does intList contain 4? {exists0}");

            int index = stringList0.IndexOf("Cherry"); // Find index of specific element
            Console.WriteLine($"Index of 'Cherry' in stringList: {index}");


            //== Sorting Lists ================================================
            List<int> unsortedList = new List<int> { 10, 5, 8, 1, 3 };
            unsortedList.Sort(); // Sort the list in ascending order


            //== Reversing a List =============================================
            unsortedList.Reverse(); // Reverse the list


            //== Other Useful Methods =========================================
            intList0.Clear(); // Clear all elements from the list


            //== Static Methods ===============================================
            List<int> copiedList = new List<int>(intList0); // Copy constructor
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
            int[] arrayFromList = intList0.ToArray(); // Convert List to Array
            Console.WriteLine("Array from List: ");
            foreach (var item in arrayFromList)
            {
                Console.Write(item + " "); // Print array elements
            }
            Console.WriteLine();
        }
    }
}
