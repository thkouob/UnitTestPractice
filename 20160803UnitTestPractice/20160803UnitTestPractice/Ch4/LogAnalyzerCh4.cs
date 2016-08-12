using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh4
    {
        private IWebService webService;
        public LogAnalyzerCh4(IWebService service)
        {
            this.webService = service;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                webService.LogError("FileName too short:" + fileName);
            }
        }
    }
}