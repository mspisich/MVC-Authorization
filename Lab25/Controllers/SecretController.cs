using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab25.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        [Authorize]
        public ActionResult Secret()
        {
            return View();
        }
    }
}