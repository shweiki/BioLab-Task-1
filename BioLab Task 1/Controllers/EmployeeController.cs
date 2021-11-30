using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class EmployeeController : Controller
    {
        public PartialViewResult Select()
        {
   
            return PartialView();

        }
      
    }
}