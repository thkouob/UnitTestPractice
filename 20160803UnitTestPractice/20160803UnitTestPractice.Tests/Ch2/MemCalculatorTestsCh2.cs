using System;
using NUnit.Framework;

namespace _20160803UnitTestPractice.Tests
{
    [TestFixture]
    public class MemCalculatorTestsCh2
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculatorCh2 calc = MackeCalc();
            int lastSum = calc.Sum();
            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangeSum()
        {
            MemCalculatorCh2 calc = MackeCalc();
            calc.Add(1);
            int lastSum = calc.Sum();
            Assert.AreEqual(1, lastSum);
        }

        private static MemCalculatorCh2 MackeCalc()
        {
            return new MemCalculatorCh2();
        }
    }
}
