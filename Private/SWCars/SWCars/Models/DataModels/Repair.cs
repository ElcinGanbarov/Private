using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{

    public class Repair : Edited
    {
        public int Id { get; set; }
        public int CarId { get; set; }
       // public Car Cars { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DetalId { get; set; }
        public SparePart SparePart { get; set; }
        public int MasterId { get; set; }
        public Master Masters { get; set; }
    }


    public class RepairConfiguration : EntityTypeConfiguration<Repair>
    {
        public RepairConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.CarId).IsRequired();
            Property(p => p.StartDate).HasColumnType("smalldatetime").IsRequired();
            Property(p => p.EndDate).HasColumnType("smalldatetime").IsRequired();
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);

            //HasRequired(r => r.Cars).WithMany(m => m.Repair).HasForeignKey(f => f.CarId);
            HasRequired(r => r.SparePart).WithMany(m => m.Repair).HasForeignKey(f => f.DetalId);
            HasRequired(r => r.Masters).WithMany(m => m.Repair).HasForeignKey(f => f.MasterId);
        }
    }
}