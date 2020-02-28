using SWCars.CustomSecurity;
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
    public class CarsController : Controller
    {
        public ActionResult Cars()
        {
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<CarViewModel> carlist = (from c in context.Car
                                              join m in context.CarModel on c.ModelId equals m.Id
                                              join ct in context.CarType on c.CarTypeId equals ct.Id
                                              join co in context.CarsOils on c.Bancode equals co.Bancode
                                              join ot in context.OilType on co.OilTypeId equals ot.Id
                                              join cm in context.CarMarka on m.MarkaId equals cm.Id

                                              where
                                              c.Status

                                              select new CarViewModel()
                                              {
                                                  Bancode = c.Bancode,
                                                  Marka = cm.Marka,
                                                  Model = m.Model,
                                                  Carno = c.CarNo,
                                                  ProductionDate = c.ProductionDate,
                                                  CarType = ct.CarTypeName,
                                                  OilType = ot.OilTypeName,
                                                  OiltypeSpesificname = ot.OilTypeSpesificName,
                                                  Remark = c.Remark

                                              }

                                   ).ToList();

                List<CarMarka> carmarkaList = (from c in context.CarMarka
                                               where c.Status
                                               select c).ToList();
                
                

                List<CarModel> carmodelList = (from c in context.CarModel
                                               where c.Status
                                                                                        
                                               select c).ToList();

                List<OilType> oiltypeList = (from o in context.OilType
                                             where o.Status
                                             select o).ToList();

                List<CarType> cartypeList = (from c in context.CarType
                                             where c.Status
                                             select c).ToList();

                ViewBag.CarList = carlist;
                ViewBag.CarmarkaList = carmarkaList;
                ViewBag.CarmodelList = carmodelList;
                ViewBag.OiltypeList = oiltypeList;
                ViewBag.CartypeList = cartypeList;

                return View();
            }
            
        }

        [HttpPost]

        public  JsonResult CreatenewCar(int Bancode,int Modelid,string Carno,DateTime Productiondate,int Cartypeid,int Oiltypeid)
        {
            ReturnModel model = new ReturnModel();
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    Car cars = (from c in context.Car
                                where
                                c.Bancode == Bancode &&
                                c.ModelId == Modelid &&
                                c.CarNo == Carno &&
                                c.ProductionDate == Productiondate &&
                                c.CarTypeId == Cartypeid &&
                                c.OilTypeId == Oiltypeid
                                select c).SingleOrDefault();
                    if (cars != null)
                    {
                        model.Message = "Mashin Bazada Movcuddur";
                        return Json(model);
                    }
                    cars = new Car();
                    cars.Bancode = Bancode;
                    
                    cars.ModelId = Modelid;
                    cars.CarNo = Carno;
                    cars.ProductionDate = Productiondate;
                    cars.CarTypeId = Cartypeid;
                    cars.OilTypeId = Oiltypeid;

                    cars.Status = true;
                    cars.EditedBy = "ELCIN";
                    cars.EditDay = DateTime.Now;
                    context.Car.Add(cars);
                    //context.SaveChanges();
                    var carsoils = new CarsOils();
                    carsoils.Bancode = Bancode;
                    carsoils.OilTypeId = Oiltypeid;
                    context.CarsOils.Add(carsoils);
                    context.SaveChanges();
                    model.Status = true;
                    model.Message = cars.Bancode.ToString();
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