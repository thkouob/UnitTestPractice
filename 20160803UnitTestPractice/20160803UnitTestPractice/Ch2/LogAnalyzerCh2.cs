using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh2
    {
        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileName) 
        {
            WasLastFileNameValid = false;

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("fileName has to be provided");
            }
            
            if (!fileName.EndsWith(".SLF", StringComparison.OrdinalIgnoreCase)) 
            {
                return false;
            }

            WasLastFileNameValid = true;
            return true;
        }
    }
}