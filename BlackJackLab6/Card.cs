using System;
using System.Net.Security;

namespace BlackJackLab6
{
    public class Card
    {
        private static string[] cardValues = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] cardSuits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();

        private int cardValue;
        private int cardSuit;

        public int CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                cardValue = value;
            }
        }
        public int CardSuit
        {
            get
            {
                return cardSuit;
            }
            set
            {
                cardValue = value;
            }
        }
        public Card()
        {
            cardValue = generator.Next(1, 14);
            cardSuit = generator.Next(1, 5);
        }
        public Card(int v, int s)
        {
            cardValue = v;
            cardSuit = s;
        }
        public bool HasMatchingSuit(Card other)
        {
            if (cardSuit == other.cardSuit)
            {
                return true;
            }
            return false;
        }
        public bool HasMatchingValue(Card other)
        {
            if (cardValue == other.cardValue)
            {
                return true;
            }
            return false;
        }
        public bool IsAce()
        {
            if (cardValue == 1)
            {
                return true;
            }
            return false;
        }
        public bool IsFaceCard()
        {
            if (cardValue > 10)
            {
                return true;
            }
            return false;
        }
        public bool IsClub()
        {
            if (cardSuit == 1)
            {
                return true;
            }
            return false;
        }
        public bool IsDiamond()
        {
            if (cardSuit == 2)
            {
                return true;
            }
            return false;
        }
        public bool IsHeart()
        {
            if (cardSuit == 3)
            {
                return true;
            }
            return false;
        }
        public bool IsSpade()
        {
            if (cardSuit == 4)
            {
                return true;
            }
            return false;
        }
        public bool IsBlack()
        {
            if (IsSpade() || IsClub())
            {
                return true;
            }
            return false;
        }
        public bool IsRed()
        {
            if (IsHeart() || IsDiamond())
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return cardValues[cardValue] + " of " + cardSuits[cardSuit];
        }
    }
}