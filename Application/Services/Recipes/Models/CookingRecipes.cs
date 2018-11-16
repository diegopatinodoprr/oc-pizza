using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace apiB.Models
{
    public class CookingRecipes
    {
        [JsonProperty("piecesOfMeat")]
        public ICollection<CookingRecipe> PiecesOfMeat { get; set;}

      
    }
    public class CookingRecipe
    {
        [JsonProperty("origin")]
        public string TypeOfCooking { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Id")]
        public int Id { get; set; }


    }
}
