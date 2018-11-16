using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace apiB.Models
{
    public class Meats
    {
        [JsonProperty("piecesOfMeat")]
        public ICollection<Meat> PiecesOfMeat { get; set;}

      
    }
    public class Meat
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dishId")]
        public int DishId { get; set; }


    }
}
