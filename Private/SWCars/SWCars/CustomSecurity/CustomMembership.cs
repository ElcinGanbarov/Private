using SWCars.Models.Context;
using SWCars.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;

namespace SWCars.CustomSecurity
{
    public class CustomMembership : MembershipProvider
    {
        public static string CustomValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return "Credentials not provided";

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                User possibleUser = (from u in context.User
                                      where
                                      string.Compare(u.Username, username, StringComparison.OrdinalIgnoreCase) == 0
                                      select u).SingleOrDefault();

                if (possibleUser == null)
                    return "Username not exist";

                if (!Crypto.VerifyHashedPassword(possibleUser.HashPassword, password))
                    return "Password not true";
                
                return "Success";
            }
        }



        public static string CustomCreateUser(string username, string firstName, string lastName, string email, string password)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                User user = (from u in context.User
                             where
                             string.Compare(username, u.Username, StringComparison.OrdinalIgnoreCase) == 0
                             select u).SingleOrDefault();


                if (user != null)
                    return "Username already exist";

                user = new User()
                {
                    Username = username,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    HashPassword = password
                };
                context.User.Add(user);
                context.SaveChanges();
                
                
                Role role = (from r in context.Role
                             where
                             r.RoleName == "User"
                             select r).SingleOrDefault();


                UserRole ur = new UserRole()
                {
                    User = user,
                    Role = role
                };

                context.UserRoles.Add(ur);
                context.SaveChanges();

                return "Success";
            }
            
            
            

            
        }






        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                User user = (from u in context.User
                            where
                            string.Compare(username, u.Username, StringComparison.OrdinalIgnoreCase) == 0
                            select u).SingleOrDefault();


                if (user == null)
                    return null;


                CustomMembershipUser selectedUser = new CustomMembershipUser(user);
                return selectedUser;
            }
        }

















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
        public override bool EnablePasswordReset
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool EnablePasswordRetrieval
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int MaxInvalidPasswordAttempts
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int MinRequiredPasswordLength
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override int PasswordAttemptWindow
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override MembershipPasswordFormat PasswordFormat
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override string PasswordStrengthRegularExpression
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool RequiresQuestionAndAnswer
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool RequiresUniqueEmail
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }
        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }
        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }
        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }
        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }
        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }
        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }
        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }
        public override bool ValidateUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}