using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tutorial6ex2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the updated version of the previous code.";

            return View();

        }
        public ActionResult contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }
        public string subject()
        {
            return "updated " +
                "list of the subject that the students have choosen"
        }
        public string newsubject(string name)
        {
            return "new subject added is: " + name
        }
        

    }
}