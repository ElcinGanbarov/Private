using Newtonsoft.Json;
using SWCars.CustomSecurity;
using SWCars.Models.Context;
using SWCars.Models.DataModels;
using SWCars.Models.IdentityModels;
using SWCars.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

using static SWCars.Models.DataModels.LoginViewModel;


namespace SWCars.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult login(string returnUrlGet)
        {
            if (!User.Identity.IsAuthenticated)
            {
                ViewBag.ReturnUrlGet = returnUrlGet;
                return View();
            }
            return RedirectToLocal(returnUrlGet);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult login(LoginViewModel model, string returnUrlPost)
        {
            string loginMessage = string.Empty;

            if (ModelState.IsValid)
            {
                loginMessage = CustomMembership.CustomValidateUser(model.UserName, model.Password);

                if (loginMessage == "Success")
                {
                    var x = Membership.GetUser(model.UserName, false);
                    var user = (CustomMembershipUser)x;

                    if (user != null)
                    {
                        SerializeModel serModel = new SerializeModel()
                        {
                            UserId = user.UserId,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Roles = user.Roles
                        };

                        string userData = JsonConvert.SerializeObject(serModel);

                        FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket
                            (
                            1, serModel.FirstName + " " + serModel.LastName, DateTime.Now, DateTime.Now.AddMinutes(15), false, userData
                            );

                        string enTicket = FormsAuthentication.Encrypt(authTicket);

                        HttpCookie faCookie = new HttpCookie("SWCarsCookie", enTicket);
                        Response.Cookies.Add(faCookie);
                    }

                    return RedirectToLocal(returnUrlPost);
                }
            }

            ViewData["LoginMessage"] = loginMessage;
            return View(model);
        }
        public ActionResult logout()
        {
            HttpCookie cookie = new HttpCookie("SWCarsCookie", "");
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);




            FormsAuthentication.SignOut();
            return RedirectToAction("login", "account", null);
        }

        public ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction("Cars", "Cars");
        }

        [AllowAnonymous]
        public ActionResult register()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult register(RegisterViewModel model)
        {
            string registrationMessage = string.Empty;

            if (ModelState.IsValid)
            {
                registrationMessage = CustomMembership.CustomCreateUser(model.UserName, model.FirstName, model.LastName, model.Email, model.Password);

                if (registrationMessage == "Success")
                {
                    string callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = model.UserName, code = Crypto.HashPassword(model.UserName) }, protocol: Request.Url.Scheme);
                    string body = "Please confirm your account by clicking <button style='background-color:deepskyblue;' onclick='location.href=\"" + callbackUrl + "\"'>Confirm Email</button>";

                    EmailService es = new EmailService();
                    es.SendMessage(model.Email, body);

                    return View("confirmemail");
                }
            }

            ViewBag.RegistrationMessage = registrationMessage;
            return View();
        }




        [AllowAnonymous]
        public ActionResult confirmemail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToAction("EmailConfirmationError", new RouteValueDictionary(new
                {
                    controller = "Error",
                    action = "EmailConfirmationError",
                    errorMessage = "Credentials hasn't been provided when confirming email ."
                }));
            }

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                User user = (from u in context.User
                             where string.Compare(userId, u.Username, StringComparison.OrdinalIgnoreCase) == 0
                             select u).SingleOrDefault();

                if (Crypto.VerifyHashedPassword(code, userId))
                {
                    user.EmailConfirmed = true;
                    context.SaveChanges();

                    return View("EmailConfirmed");
                }

                return RedirectToAction("EmailConfirmationError", new RouteValueDictionary(new
                {
                    controller = "Error",
                    action = "EmailConfirmationError",
                    errorMessage = "Wrong credentials when confirming email ."
                }));
            }

        }
     
    }
}
        
    
