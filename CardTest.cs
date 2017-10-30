using System;
using TestCardsAndDeck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCardsAndDeck
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardImplementationTest()
        {
            //value and suit as string
            //2-10 J Q K A

            CardAndDeck.Card c = new CardAndDeck.Card("A", "spades");
            Assert.AreEqual("A of Spades", c.print());

            c = new CardAndDeck.Card("9", "Clubs");
            Assert.AreEqual("9 of Clubs", c.print());

            c = new CardAndDeck.Card("9", "Diamonds");
            Assert.AreEqual("9 of Diamonds", c.print());

            c = new CardAndDeck.Card("9", "Hearts");
            Assert.AreEqual("9 of Hearts", c.print());

            c = new CardAndDeck.Card("Jack", "Clubs");
            Assert.AreEqual("J of Clubs", c.print());

            c = new CardAndDeck.Card("5", "Spades");
            Assert.AreEqual("5 of Spades", c.print());

            //--Fails Below

            c = new CardAndDeck.Card("11", "Clubs");
            Assert.AreEqual("0", c.print());

            c = new CardAndDeck.Card("10", "Clibs");
            Assert.AreEqual("0", c.print());

            c = new CardAndDeck.Card("0", "Hearts");
            Assert.AreEqual("0", c.print());

            c = new CardAndDeck.Card("-1", "Diamonds");
            Assert.AreEqual("0", c.print());

            c = new CardAndDeck.Card("-1", "Dimonds");
            Assert.AreEqual("0", c.print());

        }
    }
}
