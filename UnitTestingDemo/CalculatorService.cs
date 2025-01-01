using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class CalculatorService
    {
        public int AddtwoInts(int a, int b)
        {
            return a + b;
        }

        public double AddtwoDoubles(double a, double b)
        {
            return a + b;
        }

        public List<int> GetRandomNumbers()
        {
            var ranomNumbers = new int[] { 1, 13, 2, 43, 4, 85, 68,7, 98};
            return ranomNumbers.ToList();
        }

        public bool IsOdd(int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
