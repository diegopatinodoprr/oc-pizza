using System;
namespace MeatsApi.DomainAdapters.Persistance.Entities
{
    public class Meat
    {

        public Guid Id { get; set; }
        public string Origin { get; set; }

       
        public string Name { get; set; }


        public int DishId { get; set; }
        public Meat()
        {
        }
    }
}
