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
    public class CarModelController : Controller
    {
        //[CustomAuthorize("SuperAdmin", "Admin", "User")]

        public ActionResult Carmodel()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<CarModel> modellist = (from m in context.CarModel
                                            where
                                            m.Status
                                            select m).ToList();
                List<CarMarka> markalist = (from m in context.CarMarka
                                            where
                                            m.Status
                                            select m).ToList();

                ViewBag.CarmodelList = modellist;
                ViewBag.Carmarkalist = markalist;
                return View();
            }
        }
        [HttpPost]

        public JsonResult addmodel(string carmodel,int carmarkaid)
        {
            ReturnModel model = new ReturnModel();

            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    CarModel mymodel = (from m in context.CarModel
                                        where
                                        m.Status &&
                                        m.Model == carmodel
                                        select m).FirstOrDefault();
                    if (mymodel!=null)
                    {
                        model.Message = "Bu adda model bazada movcuddur";
                        return Json(model);
                    }
                    mymodel = new CarModel();
                    mymodel.Model = carmodel;
                    mymodel.MarkaId = carmarkaid;
                    mymodel.EditDay = DateTime.Now;
                    mymodel.Status = true;
                    mymodel.EditedBy = "Elcin";
                    context.CarModel.Add(mymodel);
                    context.SaveChanges();

                    model.Status = true;
                    model.Message = mymodel.Id.ToString();
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