using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardAndDeck;
using System.Collections.Generic;

namespace TestCardsAndDeck
{
    [TestClass]
    public class DeckTest
    {
        [TestMethod]
        public void DeckImplementationTest()
        {

            CardAndDeck.Deck d = new CardAndDeck.Deck();
            Assert.AreNotEqual(null, d);
            Assert.AreEqual(52, d.GetSize());

            d.Shuffle();
            int i = 0;
            for (; i < 52; i++)
            {
                if (!d.GetNormalList()[i].Equals(d.GetShuffledList()[i]))
                {
                    break;
                }
            }
            Assert.AreNotEqual(i, 52);

            List<Card> hand = d.Deal(5);

            Assert.AreEqual(47, d.GetSize());
            Assert.AreEqual(hand.Count, 5);

            i = 0;

            for (; i < hand.Count; i++)
            {
                Assert.AreNotEqual(true, d.CheckCard(hand[i]));
            }

            try
            {
                d.Deal(48);
                Assert.Fail();
            }
            catch (Exception)
            {
                //Could not deal that many cards, as we expect
                Assert.AreEqual(47, d.GetSize());
            }



        }
    }
}
