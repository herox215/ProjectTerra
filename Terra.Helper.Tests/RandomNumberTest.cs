using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Terra.Helper.Generation;

namespace Terra.Helper.Tests
{
    [TestClass]
    public class RandomNumberTest
    {
        [TestMethod]
        public void RandomNumberGeneratorTest()
        {
            int result = 0;
        
            RandomNumberGenerator tester = new RandomNumberGenerator();

            result = tester.GenerateNumber(1, 3);

            Assert.IsTrue(result < 4);
            Assert.IsTrue(result > 0);
        }
    }
}
