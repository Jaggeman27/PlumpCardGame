using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace PlumpTest
{
    class Deck
    {
        private readonly Tuple<int, string> CLUB = new Tuple<int, string>(1, "CLUBS");
        private readonly Tuple<int, string> DIAMOND = new Tuple<int, string>(2, "DIAMONDS");
        private readonly Tuple<int, string> HEART = new Tuple<int, string>(3, "HEARTS");
        private readonly Tuple<int, string> SPADE = new Tuple<int, string>(4, "SPADES");
        private readonly Tuple<int, string>[] COLORS = new Tuple<int, string>[4];

        private Random rand = new Random();

        private Card[] cards = new Card[52];
        private Card[] orignalDeck = new Card[52];

        public Deck() {
            COLORS[0] = CLUB;
            COLORS[1] = DIAMOND;
            COLORS[2] = HEART;
            COLORS[3] = SPADE;

            int pos = 0;

            for (int clr = 0; clr < 4; clr++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[pos] = new Card(value, COLORS[clr]);
                    pos++; 
                }
            }
            orignalDeck = cards;
        }

        public void PrintDeck()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i].toString());
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < 5; i++)
            {
                for(int pos = 0; pos < 52; pos++)
                {
                    int newPos = rand.Next(52);
                    Card temp = cards[newPos];
                    cards[newPos] = cards[pos];
                    cards[pos] = temp;
                }
                
            }
        }

        public Card[] DealCards(int amoutOfCards, int players)
        {
            int totaltAmountOfCards = amoutOfCards * players;

            if (totaltAmountOfCards > 52 || totaltAmountOfCards< 0)
            {
                throw new Exception();
            }

            Card[] dealtCards = new Card[totaltAmountOfCards];

            for (int i = 0; i <totaltAmountOfCards; i++)
            {
                dealtCards[i] = cards[i];
            }

            return dealtCards;
        }

        public Card GiveCard()
        {
            if (cards.Length >= 1)
            {
                Card card = cards[cards.Length - 1];

                Card[] temp = cards;
                cards = new Card[cards.Length - 1];

                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = temp[i];
                }

                return card;
            }
            else
            {
                return null;
            }
        }
    }
}
