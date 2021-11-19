using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.Services;
using CleanArchitectureDemo.Domain.Commands;
using CleanArchitectureDemo.Domain.CommandsHandlers;
using CleanArchitectureDemo.Domain.Core.Bus;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Infrastructure.Bus;
using CleanArchitectureDemo.Infrastructure.Data.Context;
using CleanArchitectureDemo.Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDemo.Infrastructure.IoC
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Inmemory MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDBContext>();
        }
    }
}
