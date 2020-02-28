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
  //  [CustomAuthorize("SuperAdmin", "Admin", "User")]
    public class CartypeController : Controller
    {
        // GET: Cartype
        public ActionResult Cartype()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext  context = new ApplicationDbContext())
            {
                List<CarType> typeList = (from t in context.CarType
                                          where
                                          t.Status
                                          select t).ToList();
                ViewBag.CarypeList = typeList;

                return View();
            }
        }

        [HttpPost]

        public JsonResult addtype (string type)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    CarType mytype = (from t in context.CarType
                                      where
                                      t.Status &&
                                      t.CarTypeName == type
                                      select t).FirstOrDefault();

                    if (mytype!=null)
                    {
                        model.Message = "Bu adda tip movcuddur";
                        return Json(model);
                    }
                    mytype = new CarType();
                    mytype.CarTypeName = type;
                    mytype.EditDay = DateTime.Now;
                    mytype.Status = true;
                    mytype.EditedBy = "Elcin";
                    context.CarType.Add(mytype);
                    context.SaveChanges();

                    model.Status = true;
                    model.Message = mytype.Id.ToString();
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