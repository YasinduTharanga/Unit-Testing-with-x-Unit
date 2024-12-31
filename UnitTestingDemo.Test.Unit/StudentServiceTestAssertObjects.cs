using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Test.Unit
{
    public class StudentServiceTestAssertObjects
    {
        [Fact]
        public void ShouldBeACSharpStudent()
        {
            //given
            var studentService = new StudentService();
            var courseId = 100;
            //var exceptedStudent = new CSharpStudent();

            //when
            var actualStudent = studentService.GetStudentByCourseId(courseId);

            //then
            //Assert.IsType(typeof(CSharpStudent), actualStudent);
            Assert.IsType<CSharpStudent>(actualStudent);
        }
    }
}
