using System.Collections.Generic;
using System.Linq;

namespace PP_Jonas_og_Lailai
{
    internal class Player
    {
        public List<Card> PlayerCards { get; private set; }
        private int _score = 0;

        public Player(List<Card> deckCards, int drawFrom, int drawTo)
        {
            PlayerCards = new List<Card>();
            for (int i = drawFrom; i < drawTo; i++)
            {
                PlayerCards.Add(deckCards[i]);
            }
        }

        public Card GetCard()
        {
            var drawnCard = PlayerCards.First();
            PlayerCards.Remove(drawnCard);
            return drawnCard;
        }

        public void AddPoints()
        {
            _score++;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
