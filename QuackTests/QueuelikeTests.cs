using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quack;

namespace QuackTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EnqueueItems_IdentifiesAsNotEmpty()
        {
            var sut = new Quack<string>();

            sut.Enqueue("Canvasback");
            Assert.IsFalse(sut.IsEmpty());

            sut.Enqueue("Marbled");
            Assert.IsFalse(sut.IsEmpty());
        }

        [TestMethod]
        public void DequeueAllItems_IdentifiesAsEmpty()
        {
            var sut = new Quack<string>();

            sut.Enqueue("Blue-Winged Teal");
            sut.Enqueue("Green-Winged Teal");

            sut.Dequeue();
            Assert.IsFalse(sut.IsEmpty());

            sut.Dequeue();
            Assert.IsTrue(sut.IsEmpty());
        }

        [TestMethod]
        public void Enqueue_Dequeue_SingleItem_ReturnsSuccessfully()
        {
            var sut = new Quack<string>();

            sut.Enqueue("Fulvous Whistling");
            var result = sut.Dequeue();
            Assert.AreEqual("Fulvous Whistling", result);
        }

        [TestMethod]
        public void EnqueueMultiple_DequeueIsFifo()
        {
            var sut = new Quack<string>();

            sut.Enqueue("Mallard");
            sut.Enqueue("Harlequin");
            var result = sut.Dequeue();
            Assert.AreEqual("Mallard", result);
        }
    }
}