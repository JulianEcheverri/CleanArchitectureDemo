using CleanArchitectureDemo.Domain.Commands;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.CommandsHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course() { Name = request.Name, Description = request.Description, ImageUrl = request.ImageUrl };
            return _courseRepository.Add(course);
        }
    }
}
