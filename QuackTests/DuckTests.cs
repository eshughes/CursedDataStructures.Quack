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

            var quack1 = duck.Feed("bread");
            Assert.AreEqual("bread", quack1.Pop());
            Assert.IsTrue(quack1.IsEmpty());

            var quack2 = duck.Feed(1);
            Assert.AreEqual(1, quack2.Dequeue());
            Assert.IsTrue(quack2.IsEmpty());
        }
    }
}