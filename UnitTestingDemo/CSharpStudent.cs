using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class CSharpStudent: Student
    {
        public int CourseId { get; set; }

        public int GetCourseId()
        {  
            return 100; 
        }

    }
}
