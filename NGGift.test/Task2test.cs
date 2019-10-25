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
        }
    }
}
