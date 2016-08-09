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

        [Test]
        public void IsValidFileName_SupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            LogAnalyzerCh3re log = new LogAnalyzerCh3re();
            log.ExtensionManager = myFakeManager;

            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsValidFileName_SupportedExtensionUsingFactoryClass_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            ExtensionManagerFactory.SetManager(myFakeManager); //create Analyzer, di the stub
            LogAnalyzerCh3WithFactoryClass log = new LogAnalyzerCh3WithFactoryClass();
            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsTrue(result);
        }

        [Test]
        public void OverrideTests()
        {
            FakeExtensionManager stub = new FakeExtensionManager();
            stub.WillBeValid = true;

            TestableLogAnalyzer logan = new TestableLogAnalyzer(stub);
            bool result = logan.IsValidLogFileName("file.ext");
            Assert.True(result);
        }

        [Test]
        public void OverrideTestsWithoutStub()
        {
            TestableLogAnalyzer2 logan = new TestableLogAnalyzer2();
            logan.IsSupported = true;

            bool result = logan.IsValidLogFileName("file.ext");
            Assert.IsTrue(result, "...");
        }
    }
}
