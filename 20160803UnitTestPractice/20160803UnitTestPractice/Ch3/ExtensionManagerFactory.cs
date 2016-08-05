using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager customManager = null;

        public static IExtensionManager Create()
        {
            if (customManager != null) 
            {
                return customManager;
            }

            return new FileExtensionManager();
        }

        public static void SetManager(IExtensionManager myFakeManager)
        {
            customManager = myFakeManager;
        }
    }
}