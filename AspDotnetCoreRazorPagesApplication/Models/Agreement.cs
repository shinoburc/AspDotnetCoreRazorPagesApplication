using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotnetCoreRazorPagesApplication.Models
{
    public class Agreement
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Latitude { set; get; } // 緯度
        public double Longitude { set; get; } // 経度
    }   
}
