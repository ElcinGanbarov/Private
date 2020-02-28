using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class OilFilling : Edited
    {
        public int Id { get; set; }
        public int Yurus { get; set; }
        public int Litr { get; set; }
        public int OilTypeId { get; set; }
        public OilType Oiltype { get; set; }
        public int Carid { get; set; }
        public Car car { get; set; }


    }


    public class OilFillingConfiguration : EntityTypeConfiguration<OilFilling>
    {
        public OilFillingConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.Yurus).IsRequired();
            Property(p => p.Carid).IsRequired();
            Property(p => p.Litr).IsRequired();
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);

            HasRequired(r => r.Oiltype).WithMany(m => m.OilFilling).HasForeignKey(f => f.OilTypeId);
            HasRequired(r => r.car).WithMany(m => m.Oilfilling).HasForeignKey(f => f.Carid);
        }
    }
}