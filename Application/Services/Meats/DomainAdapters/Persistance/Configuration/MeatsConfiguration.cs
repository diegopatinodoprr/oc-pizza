using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeatsApi.DomainAdapters.Persistance.Entities;

namespace Meats.DomainAdapters.Persistance.Configuration
{
    public class MeatsConfiguration: IEntityTypeConfiguration<Meat>
    {
        public void Configure(EntityTypeBuilder<Meat> builder)
        {
            builder.ToTable("meats");
            builder.HasKey(p => p.Id);


        }
    }}
