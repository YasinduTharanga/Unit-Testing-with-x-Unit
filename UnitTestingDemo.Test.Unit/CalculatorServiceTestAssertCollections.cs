using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Test.Unit
{
    public class CalculatorServiceTestAssertCollections
    {
        [Fact]
        public void ShouldNotContainZero()
        {
            //given
            var calcService = new CalculatorService();

            //when
            var actualValue = calcService.GetRandomNumbers();
            //then
            //Assert.All(actualValue, n=>Assert.NotEqual(0,n));
            Assert.DoesNotContain(0, actualValue);
        }

        [Fact]
        public void ShouldContain85()
        {
            //given
            var calcService = new CalculatorService();
            var expectedValue = 85;
            //when
            var actualValue = calcService.GetRandomNumbers();

            //then
            Assert.Contains(expectedValue, actualValue);
        }
    }
}
