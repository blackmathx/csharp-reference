using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference;
internal class _D_Arrays
{
    public static void runner()
    {
        Console.WriteLine("\n____Arrays____\n");


        int[] intArr10 = new int[5];                            // initialize array to length 5
        int[] intArray = new int[] { 1, 2, 3, 4, 5 };           // Explicit initialization
        int[] intArray2 = { 1, 3, 4 };                          // Implicit initialization
        string[] stringArray = { "Apple", "Banana", "Cherry" }; // Implicit initialization

        int var10 = intArray[0];                                // 1, access by index
        string var20 = stringArray[1];                          // "Banana", access by index

        int arrLen = intArray.Length;

        Console.WriteLine($"Length of intArray: {intArray.Length}");
        Console.WriteLine($"Length of stringArray: {stringArray.Length}");



        // Iterating Through Arrays 
        //-----------------------------------------------------------------
        int[] intArray3 = new int[] { 1, 2, 3, 4, 5 };   
        string[] stringArray3 = { "Apple", "Banana", "Cherry" }; // Implicit initialization


        foreach (var item in intArray3)                  // Using foreach to iterate
        {
            Console.Write(item + " ");
            if (item == 5) Console.WriteLine();
        }

  
        for (int i = 0; i < stringArray3.Length; i++)    // Using for loop
        {
            Console.Write(stringArray[i] + " ");
            if (i == stringArray3.Length) Console.WriteLine();
        }




        // Static methods
        //----------------------------------------------------------------
        // Array.Sort(arr);                         // Sort the array
        // Array.Reverse(arr);                      // Reverse the array
        // Array.IndexOf(arr, value);               // Get index of value
        // Array.LastIndexOf(arr, value);           // Get last index of value
        // Array.Resize(ref arr, newSize);          // Resize the array
        // Array.Clear(arr, startIndex, count);     // Clear elements
        // Array.Copy(sourceArr, destArr, length);  // Copy elements
        // Array.Exists(arr, predicate);            // Check if any element matches condition
        // Array.Find(arr, predicate);              // Find first matching element
        // Array.FindAll(arr, predicate);           // Find all matching elements
        // Array.FindIndex(arr, predicate);         // Get index of first match
        // Array.FindLast(arr, predicate);          // Find last matching element
        // Array.TrueForAll(arr, predicate);        // Check if all match condition


        // Instance methods
        //----------------------------------------------------------------
        // arr.Clone();                             // Create a shallow copy
        // arr.CopyTo(destArray, index);            // Copy to another array
        // arr.GetLength(dimension);                // Get length of a specific dimension
        // arr.GetLowerBound(dimension);            // Get lower bound index
        // arr.GetUpperBound(dimension);            // Get upper bound index
        // arr.GetValue(index);                     // Get value at index
        // arr.SetValue(value, index);              // Set value at index



        // Using Array Methods 
        // ----------------------------------------------------------------
        Array.Sort(intArray); // Sorting array
        Console.WriteLine("Sorted intArray:");
        foreach (var item in intArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        // Finding element index using Array.IndexOf
        int index = Array.IndexOf(intArray, 3);         // Finding index of element '3'
        Console.WriteLine($"Index of 3 in intArray: {index}");

        // Check if element exists using Array.Exists
        bool exists = Array.Exists(stringArray, element => element == "Banana");
        Console.WriteLine($"Does 'Banana' exist in stringArray? {exists}");

        // Clear elements in the array using Array.Clear
        Array.Clear(intArray, 0, 2); // Clears the first two elements of intArray
        Console.WriteLine("After clearing first two elements of intArray:");
        foreach (var item in intArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();





        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        // Advanced arrays



        // Multi-dimensional and Jagged Arrays 
        int[,] multiDimArray = new int[,] { { 1, 2 }, { 3, 4 } };       // 2D array
        Console.WriteLine($"Element at (1,1) in multiDimArray: {multiDimArray[1, 1]}");

        int[][] jaggedArray = new int[2][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        Console.WriteLine($"Element at jaggedArray[1][0]: {jaggedArray[1][0]}");


        // Array Conversion using Array.ConvertAll 
        string[] numberStrings = { "1", "2", "3", "4", "5" };
        int[] convertedArray = Array.ConvertAll(numberStrings, int.Parse); // Convert strings to integers. Second argument is a Converter
        Console.WriteLine("Converted array:");
        foreach (var item in convertedArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        // Array Initialization Shortcuts 
        int[] shortArray = { 10, 20, 30, 40, 50 };          // Collection initializer syntax
        Console.WriteLine("ShortArray:");
        foreach (var item in shortArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

    }
}
