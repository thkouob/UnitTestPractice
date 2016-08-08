using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class TestableLogAnalyzer : LogAnalyzerCh3UsingFactoryMethod
    {
        public IExtensionManager Manager;
        public TestableLogAnalyzer(IExtensionManager mgr) 
        {
            Manager = mgr;
        }

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
}