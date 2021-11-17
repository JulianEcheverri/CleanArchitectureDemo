using CleanArchitectureDemo.Application.ViewModels;

namespace CleanArchitectureDemo.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
