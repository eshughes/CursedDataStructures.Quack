using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quack;

namespace QuackTests
{
    [TestClass]
    public class StacklikeTests
    {
        [TestMethod]
        public void PushItems_IdentifiesAsNotEmpty()
        {
            var sut = new Quack<string>();

            sut.Push("Redhead");
            Assert.IsFalse(sut.IsEmpty());

            sut.Push("Bufflehead");
            Assert.IsFalse(sut.IsEmpty());
        }

        [TestMethod]
        public void PopAllItems_IdentifiesAsEmpty()
        {
            var sut = new Quack<string>();

            sut.Push("Common Elder");
            sut.Push("King Elder");

            sut.Pop();
            Assert.IsFalse(sut.IsEmpty());

            sut.Pop();
            Assert.IsTrue(sut.IsEmpty());
        }
    }
}