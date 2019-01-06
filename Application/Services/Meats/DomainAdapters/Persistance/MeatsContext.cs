using Meats.DomainAdapters.Persistance;
using Meats.DomainAdapters.Persistance.Configuration;
using MeatsApi.DomainAdapters.Persistance.Entities;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeatsApi.DomainAdapters.Persistance
{

    public class MeatsContext : DbContext, IMeatsContext
    {
        public DbSet<Meat> Meats { get; set; }

        public MeatsContext(DbContextOptions<MeatsContext> options): base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MeatsConfiguration());
        }

    }


}
