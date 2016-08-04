using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    //// always return true, it's a simple stub
    //// be careful of the name, it's better to be names as fakeExtensionManager, not stub or mock
    public class AlwaysValidFakeExtensionManagerCh3 : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}