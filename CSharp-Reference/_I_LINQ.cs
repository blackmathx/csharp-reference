using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference;
class _I_LINQ
{
    public static void runner()
    {

        // LINQ (Language Integrated Query) in C# is a set of features that adds native data 
        // querying capabilities to .NET languages using syntax similar to SQL. It allows querying 
        // collections like arrays, lists, XML, databases, and more in a consistent way.
        // 
        // LINQ is widely used in ASP.NET Core for:
        // 1. Data Access with Entity Framework Core. LINQ queries are translated into SQL by EF Core.
        // 2. Filtering and transforming API data
        //    var result = products
        //       .Where(p => p.InStock)
        //       .Select(p => new { p.Name, p.Price });
        // 3. Working with in-memory collections (e.g., caching, view models)


        string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

        //Get only short words
        var shortWords = from word in words where word.Length <= 5 select word;

        //Print each word out
        foreach (var word in shortWords)
        {
            Console.WriteLine(word);
        }
    }

}