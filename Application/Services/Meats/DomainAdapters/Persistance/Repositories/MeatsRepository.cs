using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MeatsApi.DomainAdapters.Persistance;
using MeatsApi.Models;

namespace Meats.DomainAdapters.Persistance.Repositories
{
    public interface IMeatsRepository
    {
        IList<Meat> GetAll();
        void AddMeat(Meat meat);
    }


    public class MeatsRepository : IMeatsRepository
    {
        private readonly IMeatsContext _meatsContext;
        private readonly IMapper _mapper;

        public MeatsRepository(IMeatsContext meatsContext, IMapper mapper)
        {
            _mapper = mapper;
            _meatsContext = meatsContext;

        }

        public void AddMeat(Meat meat)
        {

        }

        public IList<Meat> GetAll()
        {
            return _mapper.Map<IList<Meat>>(
                            _meatsContext.Meats
                            .ToList());
        }
    }
}
