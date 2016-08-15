using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class FakeEmailServiceVer2 : IEmailServiceVer2
    {
        public EmailInfo email = null;

        public void SendEmail(EmailInfo emailInfo)
        {
            email = emailInfo;
        }
    }
}