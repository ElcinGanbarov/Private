using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class AboutModel
    {
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<TeamEmployee> TeamEmployees { get; set; }
    }
}
