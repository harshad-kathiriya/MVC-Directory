using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouteConstraints.Controllers
{
    public class CardController : Controller
    {
        //
        // GET: /Card/

        public ActionResult Index(string expiry)
        {
            ViewBag.Expiry = expiry;

            return View();
        }

    }
}
