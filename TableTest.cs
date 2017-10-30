using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardAndDeck;

namespace TestCardsAndDeck
{
    [TestClass]
    public class TableTest
    {
        [TestMethod]
        public void TableImplementation()
        {

            Table t = new Table(5);

            Assert.AreEqual(5, t.numPlayers());

            Assert.AreEqual(true, t.deal(5));
            Assert.AreEqual(false, t.deal(6));

            Assert.AreEqual(27, t.numCardsLeft());

            foreach(int c in t.cardsEachPlayerHas())
            {
                Assert.AreEqual(5, c);
                Assert.AreNotEqual(6, c);
            }

            try
            {
                t = new Table(55);
                Assert.Fail();
            }
            catch (Exception)
            {
                //Could not create a table of 55 players, as we expect
            }

        }
    }
}
