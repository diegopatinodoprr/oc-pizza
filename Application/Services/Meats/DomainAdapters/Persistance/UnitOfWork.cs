using System;
using Helpers;
using MeatsApi.DomainAdapters.Persistance;

namespace MeatsApi.DomainAdapters.Persistance
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IMeatsContext _context;

        public UnitOfWork(IMeatsContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            ((MeatsContext)_context).SaveChanges();
        }
    }
}
