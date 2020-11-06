using System;

namespace PlumpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.PrintDeck();
            deck.Shuffle();
            deck.PrintDeck();
        }
    }
}
