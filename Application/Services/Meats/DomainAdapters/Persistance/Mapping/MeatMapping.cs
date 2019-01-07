using System;
using AutoMapper;

namespace MeatsApi.DomainAdapters.Persistance.Mapping
{
    public class MeatMapping:Profile
    {
        public MeatMapping()
        {
            CreateMap<MeatsApi.DomainAdapters.Persistance.Entities.Meat, MeatsApi.Models.Meat>();
        }
    }
}
