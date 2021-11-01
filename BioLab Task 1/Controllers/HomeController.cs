using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           

            Class1DBL oClass1DBL = new Class1DBL();

            List<POCO.Attendance> x = oClass1DBL.selectData();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}