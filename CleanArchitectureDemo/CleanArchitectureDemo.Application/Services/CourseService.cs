using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.Services
{
    public class CourseService : ICourseService
    {
        public IEnumerable<CourseViewModel> GetCourses()
        {
            throw new System.NotImplementedException();
        }
    }
}
