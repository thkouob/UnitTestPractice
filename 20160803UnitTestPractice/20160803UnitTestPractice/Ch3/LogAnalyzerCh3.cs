using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh3
    {
        private IExtensionManager manager;

        public LogAnalyzerCh3(IExtensionManager mgr) 
        {
            manager = mgr;
        }

        public bool IsValidLogFileName(string fileName) 
        {
            return manager.IsValid(fileName);
        }
    }
}