using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Poker
{
    enum CardSuit { pika = 1, chirva, buba, chresta };
    enum CardValue { two = 2, three, four, five, six, seven, eight, nine, ten, J, Q, K, A };
    class Card
    {
        private CardSuit suit;
        private CardValue value;
        private bool busy;
        private string unique_id;
        public static int count;

        public CardSuit Suit { get; set; }

        public CardValue Value { get; set; }

        public bool Busy { get; set; }

        public string Unique_id { get; set; }

        public Card() { count++; }

        public Card(CardSuit suit,CardValue value) : this()
        {
            Suit = suit;
            Value = value;
            int id = (int)Suit * 100 + (int)Value;
            Unique_id = id.ToString();
            Busy = true;
        }

        public string Print()
        {
            string output;
            output = GetValue();
            output += GetSuit();
            output += "\r" + "Unique_id: " + Unique_id;
            return output;
        }

        private string GetValue()
        {
            return Value switch
            {
                CardValue.two => "2",
                CardValue.three => "3",
                CardValue.four => "4",
                CardValue.five => "5",
                CardValue.six => "6",
                CardValue.seven => "7",
                CardValue.eight => "8",
                CardValue.nine => "9",
                CardValue.ten => "10",
                CardValue.J => "J",
                CardValue.Q => "Q",
                CardValue.K => "K",
                CardValue.A => "A",
                _ => "",
            };
        }

        private string GetSuit()
        {
            return Suit switch
            {
                CardSuit.pika => " Pika",
                CardSuit.chirva => " Chirva",
                CardSuit.chresta => " Kresta",
                CardSuit.buba => " Buba",
                _ => "",
            };
        }

    }
}
