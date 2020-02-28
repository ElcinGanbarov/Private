using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWCars.Models.DataModels
{
    public class Edited
    {
        public string EditedBy { get; set; }
        public string Remark { get; set; }
        public DateTime EditDay { get; set; }
        public bool Status { get; set; } = true;
    }
}