using Dev.UAA3.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dev.UAA3.Backend.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}