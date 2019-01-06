using System;
using MeatsApi.DomainAdapters.Persistance.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meats.DomainAdapters.Persistance
{
    public interface IMeatsContext
    {
        DbSet<Meat> Meats { get; set; }
    }
}
