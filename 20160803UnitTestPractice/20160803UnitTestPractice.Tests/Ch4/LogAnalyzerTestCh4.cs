using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _20160803UnitTestPractice.Tests
{
    [TestClass]
    public class LogAnalyzerTestCh4
    {
        [TestMethod]
        public void Analyze_TooShortFileName_CallWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzerCh4 log = new LogAnalyzerCh4(mockService);
            string tooShortFileName = "abc.ext";

            log.Analyze(tooShortFileName);
            StringAssert.Contains("FileName too short:abc.ext", mockService.LastError);
        }
    }
}
