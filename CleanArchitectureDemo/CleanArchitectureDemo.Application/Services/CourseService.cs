using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;
using CleanArchitectureDemo.Domain.Commands;
using CleanArchitectureDemo.Domain.Core.Bus;
using CleanArchitectureDemo.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler mediatorHandler, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mediatorHandler = mediatorHandler;
            _mapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = _mapper.Map<CreateCourseCommand>(courseViewModel);
            _mediatorHandler.SendCommand(createCourseCommand);
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}