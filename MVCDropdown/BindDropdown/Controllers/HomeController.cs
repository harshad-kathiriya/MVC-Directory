/* 
 * Developed by: Harshad Kathiriya
 * Dt: 18-Dec-2016
 * 
 */

using BindDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BindDropdown.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Country = new List<SelectListItem>() {
                new SelectListItem { Text = "India", Value = "Ïndia" }, 
                new SelectListItem { Text = "USA", Value = "USA" }, 
                new SelectListItem { Text = "UK", Value = "UK" } };


            List<SelectListItem> country = new List<SelectListItem>();
            country.Add(new SelectListItem { Text = "India", Value = "India" });
            country.Add(new SelectListItem { Text = "USA", Value = "USA" });
            country.Add(new SelectListItem { Text = "UK", Value = "UK" });
            ViewData["Country"] = country;

            var model = new CountryModel()
            {
                CountryList = country
            };


            return View(model);
        }

    }



}
