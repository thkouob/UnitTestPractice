using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20160803UnitTestPractice
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("fileName has to be provided");
            }

            if (!fileName.EndsWith(".SLF", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
