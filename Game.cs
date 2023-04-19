using System;

namespace PP_Jonas_og_Lailai
{
    internal class Game
    {
        private ConsoleKeyInfo _key;
        private Player _player1;
        private Player _player2;

        public Game(CardDeck deck)
        {
            _player1 = new Player(deck.cards, 0, 25);
            _player2 = new Player(deck.cards, 26, 51);
        }

        public void Run()
        {
            do
            {
                Console.WriteLine("Trykk Spacebar for ny runde");
                _key = Console.ReadKey(true);
                if (_key.Key == ConsoleKey.Spacebar)
                {
                    SingleRound();
                }
                else continue;

            } while (_key.Key != ConsoleKey.Escape);

        }

        private void SingleRound()
        {

            if (_player1.PlayerCards.Count != 0)
            {
                var player1Card = _player1.GetCard();
                var player2Card = _player2.GetCard();
                Console.WriteLine($"Spiller 1 trakk {player1Card.GetCard()}, spiller 2 trakk {player2Card.GetCard()}");
                if (Convert.ToInt32(player1Card.number) > Convert.ToInt32(player2Card.number))
                {
                    _player1.AddPoints();
                }
                else if (Convert.ToInt32(player1Card.number) < Convert.ToInt32(player2Card.number))
                {
                    _player2.AddPoints();
                }
                Console.WriteLine($"Stillingen er {_player1.GetScore()} : {_player2.GetScore()}");
                return;
            }

            Console.WriteLine(
                _player1.GetScore() > _player2.GetScore() ?
                    "Spiller 1 vant med " + _player1.GetScore() + " mot spiller 2s " + _player2.GetScore()
                    : "Spiller 2 vant med " + _player2.GetScore() + " mot spiller 1s " + _player1.GetScore());
        }
    }
}
