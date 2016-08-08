using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh3UsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName) 
        {
            return GetManager().IsValid(fileName);
        }

        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}