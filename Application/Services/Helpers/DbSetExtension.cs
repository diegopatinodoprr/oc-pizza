using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Helpers
{
    public static class DbSetExtension
    {
        public static void AddOrUpdate<TEntity>(this DbSet<TEntity> dbSet, TEntity entity, object entityPrimaryKeyValue, DbContext context) where TEntity : class
        {
            var existingEntity = dbSet.Find(entityPrimaryKeyValue);
            if (existingEntity == null)
            {
                dbSet.Add(entity);
            }
            else
            {
                var cfg = new MapperConfiguration(x =>
                {
                    x.CreateMap<TEntity, TEntity>();

                    x.ForAllPropertyMaps(pm => true,
                        /* la condition permet de filtrer les propritétés mappées.
                         Ici on ne veut pas mapper les classes et les interfaces pour éviter d'écraser
                         les FK des entités.*/
                        (pm, c) => c.Condition((s, d, sVal) => pm.DestinationType == typeof(string)
                                                             || (!pm.DestinationType.IsClass && !pm.DestinationType.IsInterface)));
                });
                cfg.CreateMapper().Map(entity, existingEntity);
            }
        }
    }
}
