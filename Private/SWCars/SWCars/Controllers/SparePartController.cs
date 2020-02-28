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
    public class SparePartController : Controller
    {
        public ActionResult Sparepart()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
               List<SparePart> partlist= (from m in context.SparePart
                              where m.Status
                              select m).ToList();

                ViewBag.Partlist = partlist;
                return View();
            }
            
        }
        [HttpPost]
        public JsonResult addsparepart(string partname,int partcount)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var myspart = (from p in context.SparePart
                                  where
                                  p.Status == true && p.PartName == partname
                                  select p).FirstOrDefault();
                    if (myspart != null)
                    {
                        model.Message = "Bu adda detal bazada movcuddur";
                    }

                    myspart = new SparePart();
                    myspart.PartName = partname;
                    myspart.DetailCount = partcount;
                    myspart.EditDay = DateTime.Now;
                    myspart.EditedBy = "Elcin";
                    myspart.Status = true;
                    context.SparePart.Add(myspart);
                    context.SaveChanges();
                    model.Status = true;
                    model.Message = myspart.Id.ToString();
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