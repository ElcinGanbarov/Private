using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Data
{
    public class WebSiteDbcontext:DbContext
    {
        public WebSiteDbcontext(DbContextOptions<WebSiteDbcontext> options):base(options)
        {

        }

        public DbSet<Group> Group { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
