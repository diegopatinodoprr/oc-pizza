using System;
using System.Collections.Generic;
using AutoMapper;

using MeatsApi.DomainAdapters.Persistance.Repositories;
using MeatsApi.Models;

namespace MeatsApi.Application.Queries
{
    public class MeatsService:IMeatsService
    {
        private readonly IMeatsRepository _meatsRepository;
        private readonly IMapper _mapper;

        public MeatsService(IMeatsRepository meatsRepository,IMapper mapper)
        {
            _meatsRepository = meatsRepository;
            _mapper = mapper;
        }

        public Meats GetAll()
        {
            var meats = _mapper.Map<ICollection<Meat>>(_meatsRepository.GetAll());
            return new Meats() { PiecesOfMeat=meats};
        }
    }
}
