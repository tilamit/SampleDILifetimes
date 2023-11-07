using SampleDILifetimes.Interface;
using SampleDILifetimes.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleDILifetimes.Repository
{
    public class StudentRepository : IStudent
    {
        private List<Student> _studentList;

        public StudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student() { StudentId = 1002, StudentName = "John" },
                new Student() { StudentId = 1004, StudentName = "Jack" },
                new Student() { StudentId = 1006, StudentName = "Borris" },
                new Student() { StudentId = 1008, StudentName = "Jason" },
            };
        }

        public Student Add(Student student)
        {
            student.StudentId = _studentList.Max(e => e.StudentId) + 1;
            student.StudentName = "Custom Student " + _studentList.Max(e => e.StudentId) + 1;
            
            _studentList.Add(student);
            
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }
    }
}