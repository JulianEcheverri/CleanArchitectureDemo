using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Domain.Models;
using CleanArchitectureDemo.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }
    }
}
