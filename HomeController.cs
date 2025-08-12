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
            ViewBag.Message = "This is the this is biweekly assesment 6 activity updated application description page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string subjects()
        {
            return "updated list of subjects enroilled by the students"
        }
        public string newsubject(string name)
        {
            return "newsubject added: " + name;
        }

    }
}