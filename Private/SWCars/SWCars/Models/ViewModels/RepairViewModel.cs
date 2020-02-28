using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWCars.Models.ViewModels
{
    public class RepairViewModel
    {
        public int Id { get; set; }
        public int Bancode { get; set; }
        public string Detail { get; set; }
        public string Master { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remark { get; set; }
        public string Editedby { get; set; }
        public DateTime Editday { get; set; }
        public bool Status { get; set; }
    }
}