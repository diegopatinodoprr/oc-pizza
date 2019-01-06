using System;
namespace Helpers
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
