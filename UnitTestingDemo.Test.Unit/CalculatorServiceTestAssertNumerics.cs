using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Test.Unit
{
    public class CalculatorServiceTestAssertNumerics
    {

        [Fact]
        public void ShouldInputTwoIntsAndAddThemReturnInt()
        {

            //given
            var calcService = new CalculatorService();
            var randomIntA = 2;
            var randomIntB = 5;
            var expectedValue = 7;

            //when
            var actualValue = calcService.AddtwoInts(randomIntA, randomIntB);

            //then
            Assert.Equal(expectedValue, actualValue);

        }

        [Fact]
        public void ShouldInputTwoDoublesAndAddThemAndReturnDouble()
        {

            //given
            var calcService = new CalculatorService();
            var randomDoubleA = 2.8;
            var randomDoubleB = 5.7;
            var expectedValue = 8.5;

            //when
            var actualValue = calcService.AddtwoDoubles(randomDoubleA, randomDoubleB);

            //then
            Assert.Equal(expectedValue, actualValue,1);

        }
    }
}
