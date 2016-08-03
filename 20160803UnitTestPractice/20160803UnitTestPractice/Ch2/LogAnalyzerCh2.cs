using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh2
    {
        public bool IsValidLogFileName(string fileName) 
        {
            if (!fileName.EndsWith(".SLF")) 
            {
                return false;
            }

            return true;
        }
    }
}