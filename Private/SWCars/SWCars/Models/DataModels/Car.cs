using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class Car : Edited
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bancode { get; set; }
        public int ModelId { get; set; }
        public CarModel CarModel { get; set; }
        public string CarNo { get; set; }
        public DateTime ProductionDate { get; set; }
        public int CarTypeId { get; set; }
        public CarType CarType { get; set; }
        public int OilTypeId { get; set; }
       // public ICollection<Repair> Repair { get; set; }
        public ICollection<CarsOils> CarsOil { get; set; }
        public ICollection<OilFilling> Oilfilling { get; set; }
    }


    public class CarConfiguration:EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            HasKey(k => k.Bancode);

            Property(p => p.Bancode).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.CarNo).HasMaxLength(12).HasColumnType("varchar");
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);
            HasRequired(r => r.CarModel).WithMany(m => m.Cars).HasForeignKey(f => f.ModelId);
            HasRequired(r => r.CarType).WithMany(m => m.Cars).HasForeignKey(f => f.CarTypeId);
        }
    }
    
}