using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMenu.Models;

namespace WebMenu.Data
{
    public class WebMenuContext : DbContext
    {
        public WebMenuContext (DbContextOptions<WebMenuContext> options)
            : base(options)
        {
        }

        public DbSet<WebMenu.Models.Dish> Dish { get; set; }
    }
}
