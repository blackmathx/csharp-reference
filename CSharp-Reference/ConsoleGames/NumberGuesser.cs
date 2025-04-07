using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Reference.ConsoleGames
{
    class NumberGuesser
    {
        public static void runner()
        {
            int tries = 0;
            Random rnd = new Random();
            int actual = rnd.Next(1, 101);
            Console.WriteLine("Number Guesser");
            Console.WriteLine("Guess a number between 1 and 100 in the least possible guesses");

        GameLoop:
            String guess = Console.ReadLine();
            //int res = int.Parse(guess);
            int num;
            bool success = int.TryParse(guess, out num);
            if(!success && guess == "q" || guess == "Q")
            {
                Console.WriteLine("Quitting");
                return;
            }
            if (!success) 
            {
                Console.WriteLine("Input was not an integer");
                goto GameLoop;
            }



            if(num == actual)
            {
                Console.WriteLine($"Right, {actual}. {++tries} guesses.");
                playAgain();
            } else
            {
                tries++;
                Console.WriteLine((num < actual ? "Higher" : "Lower"));
                goto GameLoop;
            }

        }

        private static void playAgain()
        {
            Console.WriteLine("Do you want to paly again? (y/n): ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                runner();
            }
            

        }
    }
}
