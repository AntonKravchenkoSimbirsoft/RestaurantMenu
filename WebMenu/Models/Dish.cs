using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMenu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Composition { get; set; }
        public int Price { get; set; }
        public int Grammar { get; set; }
        public int Calorie { get; set; }
        public DateTime CookingTime { get; set; }
    }
}
