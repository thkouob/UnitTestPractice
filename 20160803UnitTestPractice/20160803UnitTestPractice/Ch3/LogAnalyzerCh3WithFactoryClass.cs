using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class LogAnalyzerCh3WithFactoryClass
    {
        private IExtensionManager manager;

        public LogAnalyzerCh3WithFactoryClass() 
        {
            manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidLogFileName(string fileName) 
        {
            return manager.IsValid(fileName) && Path.GetFileNameWithoutExtension(fileName).Length >= 5;
        }
    }
}