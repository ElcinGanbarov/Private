using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class CarsOils
    {
        public int Bancode { get; set; }
        public Car Cars { get; set; }
        public int OilTypeId { get; set; }
        public OilType Oiltypes { get; set; }
    }


    public class CarsOilsConfiguration : EntityTypeConfiguration<CarsOils>
    {
        public CarsOilsConfiguration()
        {
            HasKey(k => new { k.Bancode, k.OilTypeId });

            HasRequired(r => r.Cars).WithMany(m => m.CarsOil).HasForeignKey(f => f.Bancode);
            HasRequired(r => r.Oiltypes).WithMany(m => m.CarsOils).HasForeignKey(f => f.OilTypeId);

        }
    }
}