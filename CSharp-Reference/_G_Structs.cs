namespace CSharp_Reference
{
    /*
    Features of C# Structs
        Structures can have methods, fields, indexers, properties, operator methods, and events.
        Structures can have defined constructors, but not destructors. However, you cannot define a default constructor for a structure. The default constructor is automatically defined and cannot be changed.
        Unlike classes, structures cannot inherit other structures or classes.
        Structures cannot be used as a base for other structures or classes.
        A structure can implement one or more interfaces.
        Structure members cannot be specified as abstract, virtual, or protected.
        When you create a struct object using the New operator, it gets created and the appropriate constructor is called. Unlike classes, structs can be instantiated without using the New operator.
        If the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized.

    Stucts vs Classes
        classes are reference types and structs are value types
        structures do not support inheritance
        structures cannot have default constructor
    */

    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void setValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    };


    internal class _G_Structs
    {
        public static void runner()
        {
            Books Book1 = new Books();   /* Declare Book1 of type Book */
            Book1.setValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            Book1.display();
        }
    }
}
