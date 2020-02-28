using AspWebSiteH.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspWebSiteH.Data
{
    public class WebSiteConnection:DbContext
    {
        public WebSiteConnection(DbContextOptions<WebSiteConnection>options):base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
