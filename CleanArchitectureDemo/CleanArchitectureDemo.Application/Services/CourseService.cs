using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;
using CleanArchitectureDemo.Domain.Commands;
using CleanArchitectureDemo.Domain.Core.Bus;
using CleanArchitectureDemo.Domain.Interfaces;

namespace CleanArchitectureDemo.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _mediatorHandler;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler mediatorHandler)
        {
            _courseRepository = courseRepository;
            _mediatorHandler = mediatorHandler;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);
            _mediatorHandler.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { Courses = _courseRepository.GetCourses() };
        }
    }
}
