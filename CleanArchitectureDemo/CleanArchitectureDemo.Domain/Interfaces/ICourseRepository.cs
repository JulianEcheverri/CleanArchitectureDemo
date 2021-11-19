using CleanArchitectureDemo.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        Task<bool> Add(Course course);
    }
}
