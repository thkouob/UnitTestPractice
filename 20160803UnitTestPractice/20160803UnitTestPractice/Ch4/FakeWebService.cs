using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class FakeWebService : IWebService
    {
        public string LastError;

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}