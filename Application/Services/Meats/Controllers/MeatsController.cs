using System.Collections.Generic;
using apiB.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiB.Controllers
{
    [Produces("application/json")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok();
        }

        [HttpGet("meats")]
        public Meats Data()
        {
            return new Meats
            {
                PiecesOfMeat = new List<Meat>
                {
                    new Meat
                    {
                        Name = "Pig",
                        Origin = "Pig",
                        DishId = 1
                    },
                    new Meat
                    {
                        Name = "steak",
                        Origin = "beef",
                        DishId = 2
                    },
                    new Meat
                    {
                        Name = "boar",
                        Origin = "boar",
                        DishId = 3
                    },
                    new Meat
                    {
                        Name = "deer",
                        Origin = "deer",
                        DishId = 4
                    }
                }
            };
        }
    }
}