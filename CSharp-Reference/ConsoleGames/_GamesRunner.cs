using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference.ConsoleGames
{
    class _GamesRunner
    {

        public static void runner()
        {
            Console.WriteLine("Let's Play Console Games!");
            Console.WriteLine("""
                Choose a game.
                1. Number Guesser
                2. Memorizing Pi
                """);


            ConsoleKeyInfo key = Console.ReadKey();
            char choice = key.KeyChar;
            Console.WriteLine();

            
            switch (choice)
            {
                case '1': NumberGuesser.runner(); break;
                case '2': MemorizingPi.runner(); break;
                case 'q':
                case 'Q':
                default: Console.WriteLine("Exiting."); break;
            }



        }





    }
}
