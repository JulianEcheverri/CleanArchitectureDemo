using AutoMapper;
using CleanArchitectureDemo.Application.ViewModels;
using CleanArchitectureDemo.Domain.Commands;

namespace CleanArchitectureDemo.Application.AutoMapper.Profiles
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(x => new CreateCourseCommand(x.Name, x.Description, x.ImageUrl));
        }
    }
}