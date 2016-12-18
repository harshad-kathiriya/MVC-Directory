using MVCLocalGlobalization.Helper;
using MVCLocalGlobalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLocalGlobalization.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Home controller
        /// </summary>
        /// <param name="culture">pass the culture (hi-IN, en-US)</param>
        /// <returns></returns>
        /// Visit for more culture list: https://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx
        /// 
        /// pass url with culture value (http://localhost:56597/Home/Index?culture=hi-IN)
        public ActionResult Index(string culture)
        {
            Culture.CurrentCulture = culture;

            UserModel userModel = new UserModel();
            return View(userModel);
        }
    }
}