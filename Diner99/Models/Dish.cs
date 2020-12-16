using System;
using System.ComponentModel.DataAnnotations;

namespace Diner99.Models
{
    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

    }
}
