using System;
using NUnit.Framework;

namespace _20160803UnitTestPractice.Tests
{
    [TestFixture]
    public class LogAnalyzerTestUsingSetupCh2
    {
        private LogAnalyzerCh2 analyzer = null;

        [SetUp] //// == Init
        public void Setup()
        {
            analyzer = new LogAnalyzerCh2();
            ////避免使用setup來做初始化
        }

        [Test]
        public void IsVaildFileName_ValidFileLowerCase_ReturnsTrue()
        {
            var result = analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "fileName should be valid!");
        }

        [Test]
        public void IsVaildFileName_ValidFileUpperCase_ReturnsTrue() 
        {
            var result = analyzer.IsValidLogFileName("whatever.slf");
            Assert.IsTrue(result, "fileName should be valid!");
        }

        ////is not really use to need
        ////
        //[TearDown]
        //public void TearDown() 
        //{
        //    analyzer = null;
            ////需要在測試之間重置一個靜態變量或單例的狀態
        //} 
    }
}
