using System.Collections.Generic;
using MeatsApi.Application.Queries;
using MeatsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeatsApi.Controllers
{
    [Produces("application/json")]
    public class MeatsController : Controller
    {

        private readonly IMeatsService _meatsService;


        public MeatsController(IMeatsService meatsService) 
        {
            _meatsService = meatsService;
         }

        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok();
        }

        [HttpGet("meats")]
        public IActionResult Data()
        {
            return Ok(_meatsService.GetAll());
            //return new MeatsApi.Models.Meats
            //{
            //    PiecesOfMeat = new List<Meat>
            //    {
            //        new Meat
            //        {
            //            Name = "Pig",
            //            Origin = "Pig",
            //            DishId = 1
            //        },
            //        new Meat
            //        {
            //            Name = "steak",
            //            Origin = "beef",
            //            DishId = 2
            //        },
            //        new Meat
            //        {
            //            Name = "boar",
            //            Origin = "boar",
            //            DishId = 3
            //        },
            //        new Meat
            //        {
            //            Name = "deer",
            //            Origin = "deer",
            //            DishId = 4
            //        }
            //    }
            //};
        }
    }
}