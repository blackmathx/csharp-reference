using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference.ConsoleGames
{
    class CardGame
    {
        ArrayList cards = new ArrayList();

        public CardGame()
        {
            cards.Add("AS");
            cards.Add("JC");
            cards.Add("KH");
        }

        public static void runner()
        {
            Console.WriteLine("Card Game");
            CardGame game = new CardGame();
            game.play();
        }

        public void play()
        {

            Console.WriteLine("Card Game");

            foreach (string str in cards)
                Console.WriteLine(str);
        }
    }
}
