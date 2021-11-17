using CleanArchitectureDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Infrastructure.Data.Context
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
