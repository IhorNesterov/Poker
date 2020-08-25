using System;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(CardSuit.pika, CardValue.three);
            Card card1 = new Card(CardSuit.chirva, CardValue.five);
            Card card2 = new Card(CardSuit.pika, CardValue.four);
            Card card3 = new Card(CardSuit.chresta, CardValue.three);
            Card card4 = new Card(CardSuit.buba, CardValue.Q);
            Card card5= new Card(CardSuit.chirva, CardValue.A);
            Card[] cards = { card, card1, card2, card3, card4, card5 };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(cards[i].Print());
                Console.WriteLine(Card.count);
            }
            Console.ReadKey();
        }
    }
}
