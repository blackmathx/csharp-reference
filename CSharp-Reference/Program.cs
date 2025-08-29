
using CSharp_Reference.ConsoleGames;
using CSharp_Reference.Utilities;


namespace CSharp_Reference;

internal class Program
{
    private static void Main(string[] args)
    {

        //_A_Intro.runner();
        //_B_Numbers.runner();
        //_C_Strings.runner();
        //_D_Arrays.runner();
        //_E_Collections.runner();
        //_F_ConditionalAndLoops.runner();
        //_G_Structs.runner();
        //_H_Classes.runner();
        //_I_LINQ.runner();
        _Z_LeetCodeStarter.runner();



        //_GamesRunner.runner();
        //_UtilsDemo.runner();

        Starter.runner();


        Console.WriteLine("\nPress Enter to exit CSharp-Reference\n");
        Console.ReadLine();
        Environment.Exit(0);
    }
}

class Starter
{
    public static void runner()
    {
        int total = 100;
        long num = 10999L;
        float amt = 1.199314159F;
        double amount = 166.99;
        char init = 'a';
        bool flag = false;
        string name = "ivan pavlov";

        string var_one = Convert.ToString(total);
        string var_thrice = var_one.ToString();
        int var_two = Convert.ToInt32(var_one);
        double var_three = Convert.ToDouble(var_one);
        string var_four = Convert.ToString(var_three);

        string name1 = "Larry";
        string name2 = "Smith";
        string fullname = string.Concat(name1, name2);
        Console.WriteLine(fullname);

        string fullname2 = $"[{name1} {name2}]";
        Console.WriteLine(fullname2);

        char ch = name[1];
        int inx = name.IndexOf("ov"); 
        Console.WriteLine(ch);
        Console.WriteLine(inx);


        // REVIEW STRINGS FILE


        string oname = "galileo galilei";
        foreach (char t in oname)
        {
            if (t == 'a') continue;
            Console.WriteLine(t);
            if (t == 'i') break;
        }


        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        Console.WriteLine(string.Join(" ", cars));

        foreach (string t in cars)
        {
            if (t == "Mazda") break;
        }

        int arrLen = cars.Length;
        Array.Sort(cars);


        // REVIEW ARRAYS FILE





    }


}

