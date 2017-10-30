using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndDeck
{
    public class Deck
    {
        List<Card> NormalDeck;
        List<Card> ShuffledDeck;
        string[] vals = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = { "Spades", "Diamonds", "Clubs", "Hearts" };

        public Deck()
        {
            NormalDeck = new List<Card>(52);
            ShuffledDeck = new List<Card>(52);
            FillDeck(NormalDeck);
            FillDeck(ShuffledDeck);
        }

        private void FillDeck(List<Card> d)
        {

            foreach(var v in vals)
            {
                foreach(var s in suits)
                {
                    Card c = new Card(v, s);
                    d.Add(c);
                }
            }

        }

        public List<Card> Deal(int num)
        {
            if (num < 0 || num > ShuffledDeck.Count)
            {
                throw new Exception();
            }

            List<Card> deal = new List<Card>();

            for (; num > 0; num--)
            {
                deal.Add(ShuffledDeck[ShuffledDeck.Count - 1]);
                ShuffledDeck.RemoveAt(ShuffledDeck.Count - 1);
            }

            return deal;
        }

        public void Shuffle()
        {
            Random rng = new Random();

            int n = ShuffledDeck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = ShuffledDeck[k];
                ShuffledDeck[k] = ShuffledDeck[n];
                ShuffledDeck[n] = value;
            }
        }

        public List<Card> GetNormalList()
        {
            return NormalDeck;
        }

        public List<Card> GetShuffledList()
        {
            return ShuffledDeck;
        }

        public int GetSize()
        {
            return ShuffledDeck.Count;
        }
        
        public bool CheckCard(Card card)
        {
            bool retVal = false;

            foreach (Card c in ShuffledDeck)
            {
                if (c.print().Equals(card.print()))
                {
                    retVal = true;
                    break;
                }
            }
            
            return retVal;
        }
    }
}
