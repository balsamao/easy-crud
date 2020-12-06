using EasyCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyCrud.Infra
{
    public class EasyDbContext : DbContext
    {
        public EasyDbContext(DbContextOptions<EasyDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EasyDbContext).Assembly);
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<DeveloperPreference> Preferences { get; set; }
        public DbSet<DeveloperSkills> Skills { get; set; }
    }
}
