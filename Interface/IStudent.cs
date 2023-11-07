using SampleDILifetimes.Models;
using System.Collections.Generic;

namespace SampleDILifetimes.Interface
{
    public interface IStudent
    {
        IEnumerable<Student> GetAllStudents();
        Student Add(Student student);
    }

}
