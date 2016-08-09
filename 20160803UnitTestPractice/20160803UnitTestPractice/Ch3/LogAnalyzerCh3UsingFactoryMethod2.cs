using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh3UsingFactoryMethod2
    {
        public bool IsValidLogFileName(string fileName) 
        {
            return this.IsValid(fileName);
        }

        protected virtual bool IsValid(string fileName)
        {
            FileExtensionManager mgr = new FileExtensionManager();
            return mgr.IsValid(fileName);
        }
    }
}