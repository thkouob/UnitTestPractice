﻿using System;
namespace _20160803UnitTestPractice
{
    public class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;
        public Exception WillThrow = null;

        public bool IsValid(string fileName)
        {
            if (WillThrow != null) 
            {
                throw WillThrow;
            }

            return WillBeValid;
        }
    }
}
