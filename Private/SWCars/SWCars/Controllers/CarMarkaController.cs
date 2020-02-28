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
    public class CarMarkaController : Controller
    {
      public ActionResult Carmarka()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<CarMarka> carlist = (from c in context.CarMarka
                                          where c.Status
                                          select c).ToList();
                ViewBag.Carlist = carlist;
                return View();
            }
        }
        [HttpPost]
        public JsonResult addCarmarka( string marka)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    CarMarka carmarka = (from c in context.CarMarka
                                         where
                                          c.Status &&
                                          c.Marka == marka
                                         select c).FirstOrDefault();

                    if (carmarka!=null)
                    {
                        model.Message = "Bu marka bazada movcuddur";
                        return Json(model);
                    }
                    
                    carmarka = new CarMarka();
                    carmarka.Marka = marka;
                    carmarka.EditDay = DateTime.Now;
                    carmarka.Status = true;
                    carmarka.EditedBy = "Elcin";
                    context.CarMarka.Add(carmarka);
                    context.SaveChanges();
                    model.Status = true;
                    model.Message = carmarka.Id.ToString();
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