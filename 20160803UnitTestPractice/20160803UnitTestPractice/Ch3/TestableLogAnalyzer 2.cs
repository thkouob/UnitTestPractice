using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class TestableLogAnalyzer2 : LogAnalyzerCh3UsingFactoryMethod2
    {

        public bool IsSupported;
        protected override bool IsValid(string fileName)
        {
            return IsSupported;
        }
    }
}