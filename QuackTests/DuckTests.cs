using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quack;

namespace QuackTests
{
    [TestClass]
    public class DuckTests
    {
        [TestMethod]
        public void FeedDuckReturnsSingleItemQuack()
        {
            var witch = new Witch();
            Duck duck = witch;

            var quacks = duck.Feed("bread", "peas");

            var quack1 = quacks[0];
            Assert.AreEqual("bread", quack1.Pop());
            Assert.IsTrue(quack1.IsEmpty());

            var quack2 = quacks[1];
            Assert.AreEqual("peas", quack2.Dequeue());
            Assert.IsTrue(quack2.IsEmpty());
        }

    }
}