using System.Linq;
using Meats.DomainAdapters.Persistance.Seeder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Meats.DomainAdapters.Persistance
{
    public static class DbContextExtensions
    {
        public static bool AllMigrationsApplied(this DbContext context)
        {
            var applied = context.GetService<IHistoryRepository>()
                  .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public static void Seed(this MigrationMeatsContext context, IHostingEnvironment hostingEnvironment)
        {
            MeatsSeeder.Seed(context, hostingEnvironment);
            // TODO : to remove once talend is connected
            context.SaveChanges();
        }
    }
}
