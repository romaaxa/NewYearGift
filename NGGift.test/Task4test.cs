using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NGGift.test
{
    [TestClass]
    public class Task4test
    {
        [TestMethod]
        public void fourthTestMethod()
        {
            //action
            //Gift g4 = new Gift();

            //g4.CalculateWeight();
            //g4.CalculatePrice();
            Gift g = new Gift();
            var swetnesses = new List<Sweetness>();
            var sweetness1 = new Candy("Alyonka", 200, 20, 60, 70, "yes");
            var sweetness2 = new Candy("Alyo", 100, 50, 50, 90, "no");
            var newlist = new List<Sweetness>();
            newlist.Add(sweetness1);
            newlist.Add(sweetness2);
            swetnesses.Add(sweetness1);
            swetnesses.Add(sweetness2);
            //
            var f = g.CalculatePrice();
            var s = g.CalculateWeight();
            Assert.AreNotSame(f, s);
        }
    }
}
