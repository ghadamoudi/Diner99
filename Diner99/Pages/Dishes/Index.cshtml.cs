using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Diner99.Data;
using Diner99.Models;

namespace Diner99.Pages.Dishes
{
    public class IndexModel : PageModel
    {
        private readonly Diner99.Data.DishContext _context;

        public IndexModel(Diner99.Data.DishContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dish.ToListAsync();
        }
    }
}
