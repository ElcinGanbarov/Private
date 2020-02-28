using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class SparePart : Edited
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public int DetailCount { get; set; }
        public ICollection<Repair> Repair { get; set; }
    }



    public class SparePartConfiguration : EntityTypeConfiguration<SparePart>
    {
        public SparePartConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.PartName).IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(p => p.DetailCount).IsRequired();
        }
    }
}