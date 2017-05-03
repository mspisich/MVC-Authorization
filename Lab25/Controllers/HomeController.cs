using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            bool isLoggedIn = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (isLoggedIn)
            {
                return RedirectToAction("Welcome", "Home");
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [Authorize]
        public ActionResult Welcome()
        {
            ViewBag.Name = User.Identity.Name;

            return View();
        }
    }
}