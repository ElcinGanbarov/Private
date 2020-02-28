using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class OilType : Edited
    {
        public int Id { get; set; }
        public string OilTypeName { get; set; }
        public string OilTypeSpesificName { get; set; }
        public ICollection<CarsOils> CarsOils { get; set; }
        public ICollection<OilFilling> OilFilling { get; set; }
    }


    public class OilTypeConfiguration : EntityTypeConfiguration<OilType>
    {
        public OilTypeConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.OilTypeName).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            Property(p => p.OilTypeSpesificName).HasColumnType("varchar").HasMaxLength(20);
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);
        }
    }
}