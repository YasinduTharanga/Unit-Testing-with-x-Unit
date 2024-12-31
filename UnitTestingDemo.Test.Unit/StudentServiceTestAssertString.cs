using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingDemo.Test.Unit
{
    public class StudentServiceTestAssertString
    {
        [Fact]
        public void ShouldReturnFullNameByGettingFirstNameAndLastName()
        {
            //AAA - Arrange Act Assert

            //given
            var studentService = new StudentService();
            var randomFirstName = "yasindu";
            var randomLastName = "tharanga";
            var expectedFullName = "Yasindu Tharanga";
            //when
            var actualFullName = studentService.CreateFullName(randomFirstName, randomLastName);
            //then
           // Assert.Equal(expectedFullName, actualFullName,ignoreCase:true);
          // Assert.Contains(randomFirstName, actualFullName);
          Assert.Matches("[a-z] [a-z]", actualFullName);

        }
    }
}
