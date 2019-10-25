using System;
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
            Gift g1 = new Gift();
            g1.AddFruit();
            g1.OutPut();
        }
    }
}
