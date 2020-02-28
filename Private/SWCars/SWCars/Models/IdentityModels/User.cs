using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SWCars.Models.IdentityModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public bool EmailConfirmed { get; set; } = false;
        public bool UserConfirmed { get; set; } = false;
        public bool Status { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }


    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(k => k.Id);
            Property(p => p.FirstName).HasMaxLength(20).IsRequired();
            Property(p => p.LastName).HasMaxLength(20).IsRequired();
            Property(p => p.Email).HasMaxLength(30).IsRequired();
            Property(p => p.Username).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            Property(p => p.HashPassword).HasColumnType("varchar").HasMaxLength(20).IsRequired();
        }
    }

}