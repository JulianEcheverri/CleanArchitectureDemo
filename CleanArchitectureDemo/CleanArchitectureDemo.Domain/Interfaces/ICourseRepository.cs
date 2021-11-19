using CleanArchitectureDemo.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        Task<bool> Add(Course course);
    }
}
