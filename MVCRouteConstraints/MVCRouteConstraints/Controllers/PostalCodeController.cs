using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouteConstraints.Controllers
{
    public class PostalCodeController : Controller
    {
        //
        // GET: /PostalCode/

        public ActionResult Index(int pin)
        {
            ViewBag.PostalCode = pin;
            return View();
        }

    }
}
