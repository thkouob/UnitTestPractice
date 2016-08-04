using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20160803UnitTestPractice
{
    public class MemCalculatorCh2
    {
        private int sum = 0;

        public void Add(int num)
        {
            sum += num;
        }

        public int Sum()
        {
            int temp = sum;
            sum = 0;
            return temp;
        }
    }
}