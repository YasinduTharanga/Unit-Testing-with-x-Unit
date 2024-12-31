using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class StudentService
    {
        public string CreateFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public bool IsPassedExam(int marks)
        {
            if (marks >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetStudentId(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email is required");
            }
            return 10;
        }
    }
}
