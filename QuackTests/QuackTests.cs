using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quack;

namespace QuackTests
{
    [TestClass]
    public class QuackTests
    {
        [TestMethod]
        public void IsEmpty_NewQuack_ReturnsEmpty()
        {
            var sut = new Quack<string>();
            Assert.IsTrue(sut.IsEmpty());
        }

    }
}