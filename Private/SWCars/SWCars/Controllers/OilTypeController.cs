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
    public class OilTypeController : Controller
    {

        public ActionResult Oiltype()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<OilType> oillist = (from o in context.OilType
                                         where o.Status
                                         select o).ToList();
                ViewBag.Oillist = oillist;
                return View();
            }
        }

        [HttpPost]

        public JsonResult addoiltype(string typename,string oiltypespesific)
        {
            ReturnModel model = new ReturnModel();

            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {

                    var mytype = (from t in context.OilType
                                  where
                                  t.Status == true && 
                                  t.OilTypeName == typename
                                  select t).FirstOrDefault();
                    if (mytype!=null)
                    {
                        model.Message = "Bu adda Yanacaq novu movcuddur";
                    }
                    mytype = new OilType();
                    mytype.OilTypeName = typename;
                    mytype.OilTypeSpesificName = oiltypespesific;
                    mytype.EditDay = DateTime.Now;
                    mytype.EditedBy = "Elcin";
                    mytype.Status = true;
                    context.OilType.Add(mytype);
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