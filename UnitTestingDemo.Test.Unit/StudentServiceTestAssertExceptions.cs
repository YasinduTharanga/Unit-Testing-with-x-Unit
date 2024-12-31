using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Test.Unit
{
    public class StudentServiceTestAssertExceptions
    {
        [Fact]
        public void EmailShouldNotBeNullOrEmpty()
        {
            //given
            var studenService = new StudentService();
            var randomEmptyEmail = string.Empty;
            var expectedMsg = "Email is required";
            //when

            //then
            var exceptionMsg = Assert.Throws<ArgumentException>(()=>studenService.GetStudentId(randomEmptyEmail));
            Assert.Equal(expectedMsg, exceptionMsg.Message);
        }
    }
}
