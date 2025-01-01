using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Test.Unit
{
    public class CalculatorServiceTestAssertTheorywithData
    {
        [Theory]
        [InlineData(1,true)]
        [InlineData(2, false)]
        [InlineData(15, true)]
        [InlineData(100, false)]
        public void ShouldTestForOddOrEvenNumbers(int value, bool expected)
        {
            //given
            var calcServie = new CalculatorService();

            //when
            var actualValue = calcServie.IsOdd(value);

            //then
            Assert.Equal(expected, actualValue);
        }
    }
}
