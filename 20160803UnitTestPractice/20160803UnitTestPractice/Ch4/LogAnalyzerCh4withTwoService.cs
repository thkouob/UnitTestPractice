using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh4withTwoService
    {
        public IWebService WebService { get; set; }

        public IEmailService EmailService { get; set; }

        public LogAnalyzerCh4withTwoService(IWebService service, IEmailService email) 
        {
            this.WebService = service;
            this.EmailService = email;
        }

        public void Analyze(string fileName)
        {
            try
            {
                WebService.LogError("FileName too short:" + fileName);
            }
            catch (Exception e)
            {
                EmailService.SendEmail("someone@somewhere.com", "can't log", e.Message);
            }
        }
    }
}