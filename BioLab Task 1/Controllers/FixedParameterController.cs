using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class FixedParameterController : Controller
    {
        public ActionResult Index()
        {           

            Class1DBL oClass1DBL = new Class1DBL();
            POCO.fixedParameter XfixedParameter = oClass1DBL.GetData();
            return View(XfixedParameter);
        }
        [HttpPost]
        public ActionResult Edit(fixedParameter FP)
        {
          //  ViewBag.Message = "Your application description page.";
            Class1DBL oClass1DBL = new Class1DBL();

            if (oClass1DBL.SetData(FP))

                return RedirectToAction("Index");
            else
                return RedirectToAction("Index");
        }


    }
}