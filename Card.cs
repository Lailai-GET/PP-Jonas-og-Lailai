using System;
using System.Collections.Generic;

namespace PP_Jonas_og_Lailai
{
    internal class Card
    {
        public string suit { get; private set; }
        public string number { get; private set; }
        private readonly CardDeck _deck;
        private Random rnd = new Random();

        public Card(CardDeck cards)
        {
            _deck = cards;
            do
            {
                PickCard();
            } while (LookForMatch());
        }

        private void PickCard()
        {
            suit = DecideSuit();
            number = DecideNumber();
        }

        private string DecideNumber()
        {
            return rnd.Next(1, 14).ToString();
        }

        private string DecideSuit()
        {
            string[] suitList = new[] { "hearts", "diamonds", "spades", "clubs" };
            return suitList[rnd.Next(4)];
        }


        private bool LookForMatch()
        {
            foreach (var card in _deck.cards)
            {
                if (card.suit == suit && card.number == number)
                {
                    return true;
                }
                continue;
            }
            return false;
        }

        public string GetCard()
        {
            return $"{number} of {suit}";
        }
    }
}
