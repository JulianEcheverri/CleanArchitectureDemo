using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.Services;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
