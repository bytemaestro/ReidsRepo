using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCA.PiratesScreen.WebAPI.Models;
using SCA.PiratesScreen.WebAPI.Common;

namespace SCA.PiratesScreen.WebAPI.UnitTesting
{
    [TestClass]
    public class UnitTestStep2Logic
    {
        //FYI: Using interface for possibility to Mock and/or for Depdendency Injection
        private IPirateBusiness piratesHelper;
 
        [TestMethod]
        public void TestSmallestTrunkSizeLogicTrueReturn()
        {
            piratesHelper = new PirateBusiness();

           
            Assert.IsTrue(piratesHelper.GetSmallestCoinAmount(3) == 79);
          
        }
        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestSmallestTrunkSizeLogicArgException()
        {
            piratesHelper = new PirateBusiness();
            Assert.IsFalse(piratesHelper.GetSmallestCoinAmount(0) == 79);

        }
    }
}
