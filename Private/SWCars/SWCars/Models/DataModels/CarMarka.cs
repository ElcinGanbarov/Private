using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class CarMarka : Edited
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public ICollection<CarModel> CarModel { get; set; }
    }
    public class CarMarkaConfiguration : EntityTypeConfiguration<CarMarka>
    {
        public CarMarkaConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.Marka).HasColumnType("varchar").IsRequired().HasMaxLength(20);
            Property(p => p.EditDay).IsRequired().HasColumnType("smalldatetime");
            Property(p => p.EditedBy).IsRequired().HasMaxLength(30);
            Property(p => p.Remark).HasMaxLength(300);
        }
    }
}