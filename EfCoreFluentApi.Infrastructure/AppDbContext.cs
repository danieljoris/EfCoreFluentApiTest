using EfCoreFluentApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfCoreFluentApi.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseNpgsql(DatabaseConnections.ByName("Postgres"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<App> Apps { get; set; }
        DbSet<AppSettings> AppSettings { get; set; }
    }
}
