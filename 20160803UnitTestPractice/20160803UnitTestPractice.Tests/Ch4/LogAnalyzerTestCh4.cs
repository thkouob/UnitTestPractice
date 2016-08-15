using System;
using NUnit.Framework;
using _20160803UnitTestPractice;

namespace _20160803UnitTestPractice.Tests
{
    [TestFixture]
    public class LogAnalyzerTestCh4
    {
        [Test]
        public void Analyze_TooShortFileName_CallWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzerCh4 log = new LogAnalyzerCh4(mockService);
            string tooShortFileName = "abc.ext";

            log.Analyze(tooShortFileName);
            StringAssert.Contains("FileName too short:abc.ext", mockService.LastError);
        }

        [Test]
        public void Analyze_WebServiceThrows_SendEmail()
        {
            FakeWebService stubService = new FakeWebService();
            stubService.ToThrow = new Exception("fake exception");

            FakeEmailService mockEmail = new FakeEmailService();
            LogAnalyzerCh4withTwoService log = new LogAnalyzerCh4withTwoService(stubService, mockEmail);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("someone@somewhere.com", mockEmail.To);
            StringAssert.Contains("fake exception", mockEmail.Body);
            StringAssert.Contains("can't log", mockEmail.Subject);
        }

        [Test]
        public void Analyze_WebServiceThrows_SendEmail_Ver2()
        {
            FakeWebService stubService = new FakeWebService();
            stubService.ToThrow = new Exception("fake exception");

            FakeEmailServiceVer2 mockEmail = new FakeEmailServiceVer2();
            LogAnalyzerCh4withTwoServiceVer2 log = new LogAnalyzerCh4withTwoServiceVer2(stubService, mockEmail);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            EmailInfo expectedEmail = new EmailInfo()
            {
                Body = "fake exception",
                To = "someone@somewhere.com",
                Subject = "can't log"
            };

            //書本內容有點錯
            //因為是比位址，所以不能兩個class去比，除非兩個class一樣，
            //ex: var a = b = new class
            //範例是 EmailInfo vs FakeEmailServiceVer2.EmailInfo 所以比對會不過
            //也可以用 Assert.AreSame
            Assert.AreEqual(expectedEmail.Body, mockEmail.email.Body);
            Assert.AreEqual(expectedEmail.To, mockEmail.email.To);
            Assert.AreEqual(expectedEmail.Subject, mockEmail.email.Subject);
        }
    }
}
