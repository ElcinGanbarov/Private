using SWCars.CustomSecurity;
using SWCars.Models.Context;
using SWCars.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWCars.Controllers
{
    //[CustomAuthorize("SuperAdmin", "Admin", "User")]
    public class MasterController : Controller
    {
        public ActionResult Master()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                List<Master> masterlist = (from m in context.Master
                                       where
                                       m.Status
                                       select m).ToList();

                ViewBag.Masterlist = masterlist;
                return View();
            }

        }

        [HttpPost]

        public JsonResult addmaster(string mastername)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    Master mymaster = (from m in context.Master
                                       where
                                       m.Status == true &&
                                       m.MasterName == mastername
                                       select m).SingleOrDefault();
                    if (mymaster!=null)
                    {
                        model.Message = "Bu adda usta movcuddur";
                        return Json(model);
                    }
                    mymaster = new Master();
                    mymaster.MasterName = mastername;
                    mymaster.Status = true;
                    mymaster.EditDay = DateTime.Now;
                    mymaster.EditedBy = "Elcin";
                    context.Master.Add(mymaster);
                    context.SaveChanges();

                    model.Status = true;
                    model.Message = mymaster.Id.ToString();
                    return Json(model);
                }
            }
            catch (Exception ex)
            {

                model.Message = ex.Message;
                return Json(model);
            }
        }
    }
}