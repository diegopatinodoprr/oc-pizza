using System.Collections.Generic;
using apiB.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiB.Controllers
{
    [Produces("application/json")]
    public class RecipesController : Controller
    {
        [HttpGet]
        public  IActionResult HealthCheck()
        {
            return Ok();
        }

        [HttpGet("/recipes")]
        public  CookingRecipes Data()
        {
            return new CookingRecipes
            {
                PiecesOfMeat = new List<CookingRecipe>
                {
                    new CookingRecipe
                    {
                        Name = "Pig BBQ",
                        TypeOfCooking = "Kitchen Oven",
                        Id = 1
                    },
                    new CookingRecipe
                    {
                        Name = "Hamburger",
                        TypeOfCooking = "Embers",
                        Id = 2
                    },
                    new CookingRecipe
                    {
                        Name = "Boar Broth",
                        TypeOfCooking = "buillon",
                        Id = 3
                    },
                    new CookingRecipe
                    {
                        Name = "Deer Broth",
                        TypeOfCooking = "buillon",
                        Id = 4
                    }
                }
            };
        }
    }
}