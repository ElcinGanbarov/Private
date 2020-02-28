using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.IdentityModels
{
    public class UserRole
    {
        public int UserId { get; set; }
        public User User { get; set; }


        public int RoleId { get; set; }
        public Role Role { get; set; }
    }


    public class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            HasKey(k => new { k.UserId, k.RoleId });

            HasRequired(r => r.User).WithMany(m => m.UserRoles).HasForeignKey(f => f.UserId);
            HasRequired(r => r.Role).WithMany(m => m.UserRoles).HasForeignKey(f => f.RoleId);
        }
    }
}