using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Public.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StaffAugmentation()
        {
            return View();
        }

        public ActionResult Web()
        {
            return View();
        }

        public ActionResult Mobile()
        {
            return View();
        }

        public ActionResult Windows()
        {
            return View();
        }

        public ActionResult Cloud()
        {
            return View();
        }

        public ActionResult Startups()
        {
            return View();
        }

        public ActionResult Training()
        {
            return View();
        }

        [ActionName("Server")]
        public ActionResult ServerAndBackEnd()
        {
            return View();
        }

        public ActionResult More()
        {
            return View();
        }
    }
}
