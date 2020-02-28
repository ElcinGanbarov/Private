using SWCars.Models.Context;
using SWCars.Models.DataModels;
using SWCars.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWCars.Controllers
{
    //[CustomAuthorize("SuperAdmin", "Admin", "User")]
    public class RepairController : Controller
    {
        public ActionResult Repair()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<RepairViewModel> mylist = (from r in context.Repair
                                                join m in context.Master on r.MasterId equals m.Id
                                                //join c in context.Car on r.CarId equals c.Bancode
                                                join d in context.SparePart on r.DetalId equals d.Id
                                                where r.Status
                                                select
                                                new RepairViewModel()
                                                {
                                                    Bancode = r.CarId,
                                                    Detail = d.PartName,
                                                    Master = m.MasterName,
                                                    StartDate = r.StartDate,
                                                    EndDate=r.EndDate,
                                                }
                                      ).ToList();
                ViewBag.Repairlist = mylist;

                List<Master> masterlist = (from m in context.Master
                                           where
                                           m.Status
                                           select m).ToList();
                ViewBag.Masterlist = masterlist;

                List<Car> carlist = (from c in context.Car
                                     where
                                     c.Status
                                     select c).ToList();
                ViewBag.Carlist = carlist;

                List<SparePart> detaillist = (from d in context.SparePart
                                              where
                                              d.Status
                                              select d).ToList();
                ViewBag.Detaillist = detaillist;




            }
            return View();
        }

        [HttpPost]
        public JsonResult addrepair(int bancode, int detailid, int masterid, DateTime startdate, DateTime enddate)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var repairlist = (from r in context.Repair
                                      where
                                      r.Status && r.CarId == bancode &&
                                      r.DetalId == detailid &&
                                      r.StartDate == startdate &&
                                      r.EndDate == enddate
                                      select r).FirstOrDefault();
                    if (repairlist != null)
                    {
                        model.Message = "Bazada bele bir temir movcuddur";
                    }
                    repairlist = new Repair();
                    repairlist.CarId = bancode;
                    repairlist.DetalId = detailid;
                    repairlist.StartDate = startdate;
                    repairlist.EndDate = enddate;
                    repairlist.Status = true;
                    repairlist.EditDay = DateTime.Now;
                    repairlist.EditedBy = "Elcin";

                    context.Repair.Add(repairlist);
                    context.SaveChanges();
                    model.Status = true;
                    model.Message = repairlist.Id.ToString();
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