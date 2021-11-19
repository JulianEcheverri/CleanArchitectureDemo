using AutoMapper;
using CleanArchitectureDemo.Application.ViewModels;
using CleanArchitectureDemo.Domain.Models;

namespace CleanArchitectureDemo.Application.AutoMapper.Profiles
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}