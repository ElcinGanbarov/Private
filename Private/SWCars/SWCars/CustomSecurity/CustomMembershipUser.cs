using SWCars.Models.Context;
using SWCars.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SWCars.CustomSecurity
{
    public class CustomMembershipUser : MembershipUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] Roles { get; set; }


        public CustomMembershipUser(User user) : base("CustomMembership", user.Username, user.Id, string.Empty, string.Empty, string.Empty, true, false, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {
            UserId = user.Id;
            
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                Roles = (from ur in context.UserRoles
                         join r in context.Role on ur.RoleId equals r.Id
                         where ur.UserId == UserId
                         select r.RoleName).ToArray();
            }
        }

    }
}