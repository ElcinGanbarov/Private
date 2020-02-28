using SWCars.Models.DataModels;
using SWCars.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SWCars.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet <CarMarka>  CarMarka { get; set; }
        public DbSet<CarModel> CarModel { get; set; }
        public DbSet<CarsOils> CarsOils { get; set; }
        public DbSet<CarType> CarType { get; set; }
        public DbSet<Master> Master { get; set; }
        public DbSet<OilFilling> OilFilling { get; set; }
        public DbSet<OilType> OilType { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<SparePart> SparePart { get; set; }

        public ApplicationDbContext() : base("name=ApplicationDbContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new CarMarkaConfiguration());
            modelBuilder.Configurations.Add(new CarModelConfiguration());
            modelBuilder.Configurations.Add(new CarsOilsConfiguration());
            modelBuilder.Configurations.Add(new CarTypeConfiguration());
            modelBuilder.Configurations.Add(new MasterConfiguration());
            modelBuilder.Configurations.Add(new OilFillingConfiguration());
            modelBuilder.Configurations.Add(new OilTypeConfiguration());
            modelBuilder.Configurations.Add(new RepairConfiguration());
            modelBuilder.Configurations.Add(new SparePartConfiguration());
            

        }
        

    }

}