using MeatsApi.DomainAdapters.Persistance.Configuration;
using MeatsApi.DomainAdapters.Persistance.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeatsApi.DomainAdapters.Persistance
{
    public class MigrationMeatsContext : DbContext
    {
        public DbSet<Meat> Meats { get; set; }

        public MigrationMeatsContext(DbContextOptions<MigrationMeatsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MeatsConfiguration());
        }

    }
}
