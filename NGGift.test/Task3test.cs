using System;
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
            Gift g3 = new Gift();
            g3.Sort();
            g3.OutPut();
        }
    }
}
