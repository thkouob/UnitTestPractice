﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _20160803UnitTestPractice.Tests
{
    [TestClass]
    public class LogAnalyzerTestCh2
    {
        [TestMethod]
        public void IsVaildFileName_BadExtension_ReturnsFalse()
        {
            //arrange
            LogAnalyzerCh2 analyzer = new LogAnalyzerCh2();
            //act
            var result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            //Assert
            Assert.IsFalse(result);
        }
    }
}
