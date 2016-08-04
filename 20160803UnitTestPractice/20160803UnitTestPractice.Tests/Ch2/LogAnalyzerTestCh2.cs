using System;
using NUnit.Framework;

namespace _20160803UnitTestPractice.Tests
{
    [TestFixture]
    public class LogAnalyzerTestCh2
    {
        [Test]
        public void IsVaildFileName_BadExtension_ReturnsFalse()
        {
            //arrange
            LogAnalyzerCh2 analyzer = new LogAnalyzerCh2();
            //act
            var result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            //Assert
            Assert.False(result);
        }

        [Test]
        public void IsVaildFileName_GoodExtensionLowerCase_ReturnsTrue()
        {
             //arrange
            LogAnalyzerCh2 analyzer = new LogAnalyzerCh2();
            //act
            var result = analyzer.IsValidLogFileName("filewithbadextension.slf");
            //Assert
            Assert.True(result);
        }

        [Test]
        public void IsVaildFileName_GoodExtensionUpperCase_ReturnsTrue()
        {
             //arrange
            LogAnalyzerCh2 analyzer = new LogAnalyzerCh2();
            //act
            var result = analyzer.IsValidLogFileName("filewithbadextension.SLF");
            //Assert
            Assert.True(result);
        }

        //// Use testCase, this filter is only in Nunit
        [TestCase("filewithgoodextension.slf")]
        [TestCase("filewithgoodextension.SLF")]
        [Test]
        public void IsVaildFileName_VaildExtension_ReturnsTrue(string fileName)
        {
            //arrange
            LogAnalyzerCh2 analyzer = new LogAnalyzerCh2();
            //act
            var result = analyzer.IsValidLogFileName(fileName);
            //Assert
            Assert.True(result);
        }

        [TestCase("filewithgoodextension.foo", false)]
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [Test]
        public void IsVaildFileName_VaildExtension_ChecksThem(string fileName, bool except)
        {
            //arrange
            LogAnalyzerCh2 analyzer = new LogAnalyzerCh2();
            //act
            var result = analyzer.IsValidLogFileName(fileName);
            //Assert
            Assert.AreEqual(except, result);
        }
    }
}
