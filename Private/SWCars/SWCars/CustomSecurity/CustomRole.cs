using SWCars.Models.Context;
using SWCars.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SWCars.CustomSecurity
{
    public class CustomRole : RoleProvider
    {
        public override bool IsUserInRole(string username, string roleName)
        {
            var userRoles = GetRolesForUser(username);
            return userRoles.Contains(roleName);
        }
        public override string[] GetRolesForUser(string username)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                return null;
            
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                string[] selectedUser = (from u in context.User
                                         join ur in context.UserRoles on u.Id equals ur.UserId
                                         join r in context.Role on ur.RoleId equals r.Id
                                         where
                                         string.Compare(u.Username, username, StringComparison.OrdinalIgnoreCase) == 0
                                         select r.RoleName).ToArray();
                
                return selectedUser;
            }
        }
        public override void CreateRole(string roleName)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                Role r = new Role()
                {
                    RoleName = roleName
                };

                context.Role.Add(r);
                context.SaveChanges();
            }
        }

        
        #region Overrides
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}