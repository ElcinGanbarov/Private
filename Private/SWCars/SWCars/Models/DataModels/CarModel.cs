using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class CarModel : Edited
    {

        public int Id { get; set; }
        public int MarkaId { get; set; }
        public CarMarka CarMarka { get; set; }
        public string Model { get; set; }
        public ICollection<Car> Cars { get; set; }
    }


    public class CarModelConfiguration : EntityTypeConfiguration<CarModel>
    {
        public CarModelConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.Model).IsRequired().HasMaxLength(20).HasColumnType("varchar");
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);
            HasRequired(r => r.CarMarka).WithMany(m => m.CarModel).HasForeignKey(f => f.MarkaId);
        }
    }
}