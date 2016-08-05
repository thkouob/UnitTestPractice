using System;
using NUnit.Framework;
using _20160803UnitTestPractice;

namespace _20160803UnitTestPractice.Tests
{
    [TestFixture]
    public class LogAnalyzerTestsCh3
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager(); //prepare a stub
            myFakeManager.WillBeValid = true;

            LogAnalyzerCh3 log = new LogAnalyzerCh3(myFakeManager);

            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsValidFileName_ExtManagerThrowsException_ReturnsFalse()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillThrow = new Exception("this is fake");

            LogAnalyzerCh3 log = new LogAnalyzerCh3(myFakeManager);
            bool result = log.IsValidLogFileName("anything.anyextension");
            Assert.IsFalse(result);
        }
    }
}
