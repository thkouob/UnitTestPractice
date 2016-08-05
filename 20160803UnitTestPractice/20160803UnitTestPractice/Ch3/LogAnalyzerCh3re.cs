using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh3re
    {
        private IExtensionManager manager;

        public LogAnalyzerCh3re() 
        {
            manager = new FileExtensionManager();
        }

        public IExtensionManager ExtensionManager 
        {
            get { return manager; }
            set { manager = value; }
        }

        public bool IsValidLogFileName(string fileName) 
        {
            return manager.IsValid(fileName);
        }
    }
}