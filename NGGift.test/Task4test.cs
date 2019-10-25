using System;
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
            Gift g4 = new Gift();
            g4.CalculateWeight();
            g4.CalculatePrice();
        }
    }
}
