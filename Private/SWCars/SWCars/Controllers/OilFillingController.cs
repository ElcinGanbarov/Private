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
    public class OilFillingController : Controller
    {
        public ActionResult Oilfilling()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<OilFilling> fillinglist = (from o in context.OilFilling
                                                where
                                                o.Status == true
                                                select o).ToList();
                List<Car> carlist = (from c in context.Car
                                     where
                                     c.Status
                                     select c).ToList();
                List<OilType> typelist = (from t in context.OilType
                                          where
                                          t.Status
                                          select t).ToList();
                ViewBag.Carlist = carlist;
                ViewBag.Typelist = typelist;
                ViewBag.Fillinglist = fillinglist;
            }
            return View();
        }
        [HttpPost]

        public JsonResult addoilfilling(int oiltypeid, int litr, int yurus, int bancode)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var mylist = (from m in context.OilFilling
                                  where
                                  m.Status && m.Carid == bancode &&
                                  m.Yurus == yurus
                                  select m
                                  ).FirstOrDefault();
                    if (mylist != null)
                    {
                        model.Message = "Bazada bele bir melumat movcuddur";
                    }

                    mylist = new OilFilling();
                    mylist.Litr = litr;
                    mylist.OilTypeId = oiltypeid;
                    mylist.Status = true;
                    mylist.Carid = bancode;
                    mylist.Yurus = yurus;
                    mylist.EditDay = DateTime.Now;
                    mylist.EditedBy = "Elcin";
                    context.OilFilling.Add(mylist);
                    context.SaveChanges();
                    model.Status = true;
                    model.Message = mylist.Id.ToString();
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