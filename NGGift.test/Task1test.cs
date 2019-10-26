using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NGGift.test
{
    [TestClass]
    public class Task1test
    {
        [TestMethod]
        public void firstTestMethod()
        {
            //action
            var swetnesses = new List<Sweetness>();
            var sweetness1 = new Candy("Alyonka", 100, 20, 50, 70, "yes");
            var sweetness2 = new Candy("Alyo", 100, 50, 50, 90, "yes");
            var newlist = new List<Sweetness>();
            newlist.Add(sweetness1);
            newlist.Add(sweetness2);
            Assert.AreNotSame(swetnesses, newlist);
        }
    }
}
