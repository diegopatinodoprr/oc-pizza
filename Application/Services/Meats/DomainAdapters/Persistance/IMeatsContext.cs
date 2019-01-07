using System;
using MeatsApi.DomainAdapters.Persistance.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeatsApi.DomainAdapters.Persistance
{
    public interface IMeatsContext
    {
        DbSet<Meat> Meats { get; set; }
    }
}
