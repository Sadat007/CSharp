using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultipliyerTestsLib
{
    [TestClass]
    public class PurchaseCalculationTest
    {
        [TestMethod]
        public void ExcludedVAT()
        {
            var sut = new PurchaseCalculationTest();
            var total = sut.Execute(10, 100.0M,false);
            Assert.AreEqual(1000.0M,total);
        }
        [TestMethod]
        public void IncludedVAT()
        {
            var sut = new PurchaseCalculationTest();
            var total = sut.Execute(10, 100.0M, true);
            Assert.AreEqual(1200.0M, total);
        }

        public decimal Execute(int qty, decimal amount, bool withVat)
        {
            if (withVat)
                return qty * amount * 1.2M;
            else
                return qty * amount;

        }


    }
}
