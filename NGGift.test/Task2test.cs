using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NGGift.test
{
    [TestClass]
    public class Task2test
    {
        [TestMethod]
        public void secondTestMethod()
        {
            //action
            Gift g = new Gift();
            Candy c = new Candy();
            c = g.TheHaviestCandy();

            var candy1 = new Candy("Alyonka", 100, 20, 50, 70, "yes");

            Assert.AreNotEqual(candy1, c);
        }
    }
}
