using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackLab6
{
    public class Hand : Deck
    {
        private List<Card> cards = new List<Card>();
        public Hand() : base(){ }
        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public Card Discard(int index)
        {
            Card hold = cards[index];
            cards.RemoveAt(index);
            return hold;
        }
        public Card GetCard(int index)
        {
            return cards[index];
        }
        public bool HasCard(Card c)
        {
            return cards.Contains(c);
        }
        public bool HasCard(int value)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (value == cards[i].CardValue) return true;
            }
            return false;
        }
        public bool HasCard(int value, int suit)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (value == cards[i].CardValue && suit == cards[i].CardSuit) return true;
            }
            return false;
        }
        public int IndexOf(Card c)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (c == cards[i]) return i;
            }
            return -1;
        }
        public int IndexOf(int value)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].CardValue == value) return i;
            }
            return -1;
        }
        public int IndexOf(int value, int suit)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (value == cards[i].CardValue && suit == cards[i].CardSuit) return i;
            }
            return -1;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
