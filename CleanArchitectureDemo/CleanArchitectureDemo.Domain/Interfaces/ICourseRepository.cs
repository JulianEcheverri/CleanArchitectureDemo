using CleanArchitectureDemo.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
