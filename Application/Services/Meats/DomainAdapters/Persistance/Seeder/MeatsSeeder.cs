using System.Collections.Generic;
using System.Linq;
using MeatsApi.DomainAdapters.Persistance.Entities;
using Microsoft.AspNetCore.Hosting;
namespace MeatsApi.DomainAdapters.Persistance.Seeder
{
    public static class MeatsSeeder
    {
        private static MigrationMeatsContext Context { get; set; }
        public static void Seed(MigrationMeatsContext context, IHostingEnvironment hostingEnvironment)
        {
            Context = context;
            Context.RemoveRange(Context.Meats.ToList());
            SeedMeats();
            Context.SaveChanges();
            ;
        }

        public static void SeedMeats()
        {


            var meats = new List<Meat>{
                    new Meat
                    {
                        Name = "Pig",
                        Origin = "Pig",
                        DishId = 1
                    },
                    new Meat
                    {
                        Name = "steak",
                        Origin = "beef",
                        DishId = 2
                    },
                    new Meat
                    {
                        Name = "boar",
                        Origin = "boar",
                        DishId = 3
                    },
                    new Meat
                    {
                        Name = "deer",
                        Origin = "deer",
                        DishId = 4
                    }
            };
            meats.ForEach((obj) => Context.Meats.Add(obj));
        }
    }
}
