using CleanArchitectureDemo.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
