using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class ReturnModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }


    public class AjaxDataModel
    {
        public bool Status { get; set; }
        public string JsonData { get; set; }
    }
}