using System;
using AutoMapper;

namespace Meats.DomainAdapters.Persistance.Mapping
{
    public class MeatMapping:Profile
    {
        public MeatMapping()
        {
            CreateMap<MeatsApi.DomainAdapters.Persistance.Entities.Meat, MeatsApi.Models.Meat>();
        }
    }
}
