using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndDeck
{
    public class Table
    {
        private Deck deck;
        private List<List<Card>> Players;

        public Table (int numberOfPlayers)
        {
            if (numberOfPlayers > 0 && numberOfPlayers < 53)
            {
                deck = new Deck();
                deck.Shuffle();

                Players = new List<List<Card>>(numberOfPlayers);

                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Players.Add(new List<Card>());
                }
            }
            else
            {
                throw new Exception();
            }

            
        }

        public bool deal (int numCards)
        {

            if (numCards * Players.Count() > deck.GetSize())
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Players.Count; i++)
                {
                    foreach (Card c in deck.Deal(numCards))
                    {
                        Players[i].Add(c);
                    }
                }

                return true;
            }
        }

        public int numPlayers()
        {
            return Players.Count();
        }

        public int numCardsLeft()
        {
            return deck.GetSize();
        }

        public List<int> cardsEachPlayerHas()
        {
            List<int> counts = new List<int>();

            foreach(var p in Players)
            {
                counts.Add(p.Count());
            }

            return counts;
        }

    }
}
