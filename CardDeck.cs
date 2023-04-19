
using System;
using System.Collections.Generic;

namespace PP_Jonas_og_Lailai
{
    internal class CardDeck
    {
        public List<Card> cards { get; private set; }

        public CardDeck()
        {
            cards = new List<Card>();
            for (var index = 0; index < 51; index++)
            {
                cards.Add(new Card(this));
            }

        }
    }
}
