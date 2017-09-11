using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultipliyerLib;

namespace MultipliyerTestsLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Simple()
        {
            var sut = new Multipliyer();
            var actual = sut.Simple(20, 20);
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void Usingfor()
        {
            var sut = new Multipliyer();
            var actual = sut.Usingfor(20, 20);
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void While()
        {
            var sut = new Multipliyer();
            var actual = sut.While(20, 20);
            Assert.AreEqual(400, actual);
        }
    }
}
