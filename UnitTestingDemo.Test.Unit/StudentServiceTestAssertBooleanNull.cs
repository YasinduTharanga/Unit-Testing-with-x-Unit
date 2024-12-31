using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Test.Unit
{
    public class StudentServiceTestAssertBooleanNull
    {
        [Fact]
        public void ShouldPassedTheExamWithCorrectMarks()
        {
            //given
            var studentService = new StudentService();
            var randomMarks = 65;
            //var expectedValue = true;

            //when
            var actualValue = studentService.IsPassedExam(randomMarks);

            //then
            Assert.True(actualValue);
        }

        [Fact]
        public void ShouldFailTheExamWithWrongMarks()
        {
            //given
            var studentService = new StudentService();
            var randomMarks = 45;
            //var expectedValue = true;

            //when
            var actualValue = studentService.IsPassedExam(randomMarks);

            //then
            Assert.False(actualValue);
        }

        [Fact]
        public void ShouldFullNameBeNotNull()
        {
            //given
            var studentService = new StudentService();
            var randomFirstName = "yasindu";
            var randomLastName = "tharanga";
            //var expectedFullName = "Yasindu Tharanga";

            //when
            var actualValue = studentService.CreateFullName(randomFirstName, randomLastName);

            //then
            Assert.NotNull(actualValue);
        }
    }
}
