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
            var quack1 = new Duck().Feed("bread");
            Assert.Equals("bread", quack1.Pop());
            Assert.IsTrue(quack1.IsEmpty());

            var quack2 = new Duck().Feed(1);
            Assert.Equals(1, quack2.Dequeue());
            Assert.IsTrue(quack2.IsEmpty());
        }
    }
}