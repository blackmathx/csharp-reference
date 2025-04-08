using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference
{
    class _I_EF
    {
        /*
                Entity Framework is an Object-Relational Mapper (ORM) for .NET. It allows developers to work with a database using .NET objects, eliminating most of the data-access code.

                EF handles:
                    Mapping database tables to C# classes
                    Generating SQL queries automatically
                    Change tracking and saving data

                Is ADO.NET in EF?

                ✅ Yes – EF is built on top of ADO.NET.
                EF internally uses ADO.NET (SqlConnection, SqlCommand, etc.) to talk to the database, but abstracts that away from the developer.
                
                Is LINQ in EF?

                ✅ Yes – LINQ is a core part of Entity Framework.
                    With LINQ to Entities, you can write queries like:

                var users = _context.Users.Where(u => u.IsActive).ToList();

                EF translates this LINQ expression into SQL and executes it via ADO.NET.

                In modern ASP.NET Core apps, EF Core + LINQ is the preferred approach unless low-level control or performance tuning is needed.

        */
    }
}
