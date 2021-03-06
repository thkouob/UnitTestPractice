﻿using System;
using NUnit.Framework;

namespace _20160803UnitTestPractice.Tests
{
    [TestFixture] ////nunit filter == [TestClass]
    public class LogAnalyzerTestCh2
    {
        [Test] ////nunit filter == [TestMethod]
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

        [Test]
        public void IsVaildFileName_EmptyFileName_Throws()
        {
            LogAnalyzerCh2 la = MakeAnalyzer();
            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
            StringAssert.Contains("fileName has to be provided", ex.Message);
            ////使用assert.catch返回exception對象
        }

        [Test]
        [Category("Fast tests")]
        [Ignore("there is a problem with this test")]
        public void IsVaildFileName_ValidFile_ReturnsTrue()
        {
            //// just test for [Ignore] filter
            ////can follow the category to testing in Nunit
        }

        [Test]
        public void IsVaildFileName_EmptyFileName_ThrowsFluent()
        {
            LogAnalyzerCh2 la = MakeAnalyzer();
            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
            Assert.That(ex.Message, Is.StringContaining("fileName has to be provided"));
            //// also can use Assert.something();
        }

        //[Test]
        //public void IsVaildFileName_WhenCalled_ChangeWasLastFileNameValid()
        //{
        //    LogAnalyzerCh2 la = MakeAnalyzer();
        //    la.IsValidLogFileName("badname.foo");
        //    Assert.False(la.WasLastFileNameValid);
        //}

        //// refactory IsVaildFileName_WhenCalled_ChangeWasLastFileNameValid
        [TestCase("badname.foo", false)]
        [TestCase("goodname.slf", true)]
        public void IsVaildFileName_WhenCalled_ChangeWasLastFileNameValid(string fileName, bool except)
        {
            LogAnalyzerCh2 la = MakeAnalyzer();
            la.IsValidLogFileName(fileName);
            Assert.AreEqual(except, la.WasLastFileNameValid);
        }

        #region Private method
        private LogAnalyzerCh2 MakeAnalyzer()
        {
            return new LogAnalyzerCh2();
        }
        #endregion 
    }
}
