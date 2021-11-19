using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Domain.Models;
using CleanArchitectureDemo.Infrastructure.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }

        public IQueryable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }

        public Task<bool> Add(Course course)
        {
            _universityDBContext.Add(course);
            return Task.FromResult(_universityDBContext.SaveChanges() > 0);
        }
    }
}