using System;

namespace PP_Jonas_og_Lailai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new CardDeck();
            var game = new Game(deck);
            game.Run();

            Console.ReadLine();
        }
    }
}
