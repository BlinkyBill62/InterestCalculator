using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterestCalculator.Evaluate;

namespace InterestCalculator.UnitTest
{
    [TestClass]
    public class InterestCalculatorUnitTest
    {
        [TestMethod]
        public void Test_AccountBalancelessthanZero()
        {
            var interestprocessor = new InterestEvaluateProcessor();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => interestprocessor.Interest(-2000));
        }

        [TestMethod]
        public void Test_Valid_Arguments()
        {
            var interestprocessor = new InterestEvaluateProcessor();
            Assert.IsNotNull(interestprocessor.Interest(1001));

        }
    }
}
