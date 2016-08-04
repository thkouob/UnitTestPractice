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
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("fileName has to be provided");
            }
            
            if (!fileName.EndsWith(".SLF", StringComparison.OrdinalIgnoreCase)) 
            {
                return false;
            }

            return true;
        }
    }
}