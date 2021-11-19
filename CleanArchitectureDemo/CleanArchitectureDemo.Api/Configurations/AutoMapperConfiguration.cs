﻿using Microsoft.Extensions.DependencyInjection;
using ApplicationAutoMapperConfiguration = CleanArchitectureDemo.Application.AutoMapper.AutoMapperConfiguration;

namespace CleanArchitectureDemo.Api.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationAutoMapperConfiguration));
            ApplicationAutoMapperConfiguration.RegisterMappings();
        }
    }
}