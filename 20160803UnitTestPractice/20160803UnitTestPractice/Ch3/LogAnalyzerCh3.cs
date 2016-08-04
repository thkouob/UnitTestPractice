using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh3
    {
        public bool IsValidLogFileName(string fileName) 
        {
            FileExtensionManager mgr = new FileExtensionManager();

            return mgr.IsValid(fileName);
        }
    }
}