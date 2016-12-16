using MVCCustomRoute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomRoute.Controllers
{
    public class CityController : Controller
    {

        // URL
        //http://localhost:56597/City/ahmedabad


        // Temporary model
        List<CityModel> cityList = new List<CityModel>(){
            new CityModel(){
                 Name="ahmedabad",
                 area = new List<AreaModel>(){ new AreaModel{ name="Prahaladnagar"},new AreaModel{ name="S.G.Highway"}}
            },
            new CityModel(){
                 Name="NewDelhi",
                 area = new List<AreaModel>(){ new AreaModel{ name="Sansad Marg"},new AreaModel{ name="Red Fort"}}

            },
            new CityModel(){
                 Name="Mumbai",
                 area = new List<AreaModel>(){ new AreaModel{ name="Varsova"},new AreaModel{ name="Gateway of india"}}

            }
        };

        public ActionResult Index(string name)
        {

            var ct = cityList.Where(m => m.Name.ToLower().Equals(name.ToLower())).ToList();

            if (ct != null)
                return View(ct);
            else
                return View();
        }

    }
}