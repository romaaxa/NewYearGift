using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NGGift.test
{
    [TestClass]
    public class Task3test
    {
        [TestMethod]
        public void thirdTestMethod()
        {
            //action
            //Gift g3 = new Gift();
            //g3.Sort();
            //g3.OutPut();
            Gift g = new Gift();
            var swetnesses = new List<Sweetness>();
            var sweetness1 = new Candy("Alyonka", 200, 20, 60, 70, "yes");
            var sweetness2 = new Candy("Alyo", 100, 50, 50, 90, "no");
            var newlist = new List<Sweetness>();
            newlist.Add(sweetness1);
            newlist.Add(sweetness2);
            swetnesses.Add(sweetness1);
            swetnesses.Add(sweetness2);
            swetnesses.Sort();
            Assert.AreNotEqual(swetnesses, newlist);
        }
    }
}
