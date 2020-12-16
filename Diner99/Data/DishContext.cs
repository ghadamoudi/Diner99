using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Diner99.Models;

namespace Diner99.Data
{
    public class DishContext : DbContext
    {
        public DishContext (DbContextOptions<DishContext> options)
            : base(options)
        {
        }

        public DbSet<Diner99.Models.Dish> Dish { get; set; }
    }
}
