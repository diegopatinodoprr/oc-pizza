using System;
using MeatsApi.Models;
namespace MeatsApi.Application.Queries
{
    public interface IMeatsService
    {
        Meats GetAll();
    }
}
