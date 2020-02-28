using FinalProject.Models;
using FinalProject.Models.Comments;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandCategory> BrandCategories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<TeamEmployee> TeamEmployees { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<BrandCarusel> BrandCarusels { get; set; }
        public DbSet<BioHeader> BioHeaders { get; set; }
        public DbSet<BioFooter> BioFooters { get; set; }
   


    }
}
