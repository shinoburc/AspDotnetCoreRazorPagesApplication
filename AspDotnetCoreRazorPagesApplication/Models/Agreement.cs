using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspDotnetCoreRazorPagesApplication.Models
{
    public class Agreement
    {
        public int Id { set; get; }

        [Display(Name = "契約名")]
        public string Name { set; get; }

        [Display(Name = "緯度")]
        public double Latitude { set; get; }

        [Display(Name = "経度")]
        public double Longitude { set; get; }
    }   
}
