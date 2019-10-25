using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NGGift.test
{
    [TestClass]
    public class Task5test
    {
        [TestMethod]
        public void fifthTestMethod()
        {
            bool tester = false;
            
            //action
            Gift g5 = new Gift();
            g5.OutPutFile(@"E:\hackerman\txtfiles\output.txt");
            
        }
    }
}
