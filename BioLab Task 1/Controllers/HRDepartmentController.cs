using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class HRDepartmentController : Controller
    {
        public PartialViewResult Select()
        {
            DBL_HRDepartment oClass1DBL = new DBL_HRDepartment();
            List<POCO.Department> XDepartment = oClass1DBL.GetData();
            return PartialView(XDepartment);

        }
      
    }
}