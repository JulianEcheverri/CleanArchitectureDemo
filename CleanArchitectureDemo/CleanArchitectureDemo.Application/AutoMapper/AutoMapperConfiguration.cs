using AutoMapper;
using CleanArchitectureDemo.Application.AutoMapper.Profiles;

namespace CleanArchitectureDemo.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x =>
            {
                x.AddProfile(new ViewModelToDomainProfile());
                x.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}