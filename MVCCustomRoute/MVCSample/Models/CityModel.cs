using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomRoute.Models
{
    public class CityModel
    {
        public string Name { get; set; }
        public List<AreaModel> area { get; set; }

    }
}