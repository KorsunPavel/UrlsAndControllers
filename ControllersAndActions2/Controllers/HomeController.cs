using ControllersAndActions2.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";

            return View("MyAction");
            
        }

        public ActionResult ProduceOutput()
        {
            if (Server.MachineName == "ZEBRA-0601")
            {
                return new CustomRedirectResult { Url = "/Home/Index" };
            }
            else
            {
                Response.Write("Controller: Derived, Action: ProduceOutput");
                return null;
            }
        }
    }
}