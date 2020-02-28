using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWCars.Models.ViewModels
{
    public class CarViewModel
    {
        public int Bancode { get; set; }
        public string Marka { get; set; }
        public string  Model { get; set; }
        public string  Carno { get; set; }
        public DateTime ProductionDate { get; set; }
        public string CarType { get; set; }
        public string OilType { get; set; }
        public string Remark { get; set; }
        public string OiltypeSpesificname { get; set; }

    }
}