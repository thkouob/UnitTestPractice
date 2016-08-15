using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh4withTwoServiceVer2
    {
        public IWebService WebService { get; set; }

        public IEmailServiceVer2 EmailService { get; set; }

        public LogAnalyzerCh4withTwoServiceVer2(IWebService service, IEmailServiceVer2 email) 
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
                EmailInfo emailData = new EmailInfo() 
                {
                    Body = e.Message.ToString(),
                    To = "someone@somewhere.com",
                    Subject = "can't log"
                };

                EmailService.SendEmail(emailData);
            }
        }
    }
}