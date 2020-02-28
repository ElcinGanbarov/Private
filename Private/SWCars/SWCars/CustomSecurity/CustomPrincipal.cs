using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SWCars.CustomSecurity
{
    public class CustomPrincipal : IPrincipal
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] Roles { get; set; }

        
        public CustomPrincipal(string username)
        {
            Identity = new GenericIdentity(username);
        }



        public IIdentity Identity
        {
            get; private set;
        }


        public bool IsInRole(string rolesFromAuthorize)
        {
            foreach (string r in Roles)
            {
                if (rolesFromAuthorize.Contains(r))
                    return true;
            }

            return false;
        }
    }
}