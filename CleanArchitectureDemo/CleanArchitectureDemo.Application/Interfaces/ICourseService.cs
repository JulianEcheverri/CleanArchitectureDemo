using CleanArchitectureDemo.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}
