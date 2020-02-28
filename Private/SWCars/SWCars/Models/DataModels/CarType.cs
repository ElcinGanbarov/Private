using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class CarType : Edited
    {
        public int Id { get; set; }
        public string CarTypeName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }

    public class CarTypeConfiguration : EntityTypeConfiguration<CarType>
    {
        public CarTypeConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.CarTypeName).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);
            
        }
    }
}