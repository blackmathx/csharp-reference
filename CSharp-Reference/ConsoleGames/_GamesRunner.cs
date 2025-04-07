using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference.ConsoleGames
{
    class _GamesRunner
    {

        _GamesRunner()
        {

        }

        /// <summary>
        /// The main static method for _GamesRunner that begins console games
        /// </summary>
        public static void runner()
        {
            Console.WriteLine("Let's Play Console Games!");
            Console.WriteLine("""
                Choose a game.
                1. Number Guesser
                2. Memorizing Pi
                3. Card Game
                """);


            ConsoleKeyInfo key = Console.ReadKey();
            char choice = key.KeyChar;
            Console.WriteLine();

            
            switch (choice)
            {
                case '1': NumberGuesser.runner(); break;
                case '2': MemorizingPi.runner(); break;
                case '3': CardGame.runner(); break;
                case 'q':
                case 'Q':
                default: Console.WriteLine("Exiting."); break;
            }

            bool res = playConsoleGamesAgain("yes");

        }

        /// <summary>
        /// This method asks the player if they would like to play another one of the console games.
        /// </summary>
        /// <param name="ans">Currently takes any input. In the future, something useful</param>
        /// <returns>True or false based on nothing whatsoever</returns>
        public static bool playConsoleGamesAgain(string ans)
        {
            Console.WriteLine("Do you want to paly another game? (y/n): ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                runner();
            }

            return true;
        }




    }
}
