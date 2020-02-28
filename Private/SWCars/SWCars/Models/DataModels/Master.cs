using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class Master : Edited
    {
        public int Id { get; set; }
        public string MasterName { get; set; }
        public ICollection<Repair> Repair { get; set; }
    }


    public class MasterConfiguration : EntityTypeConfiguration<Master>
    {
        public MasterConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.MasterName).HasMaxLength(30).IsRequired();
        }
    }
}