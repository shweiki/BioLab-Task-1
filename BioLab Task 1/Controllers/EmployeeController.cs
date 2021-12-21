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
            DBL_StaffBasicinformation_Select oClass1DBL = new DBL_StaffBasicinformation_Select();
            List<POCO.StaffBasicInformation> XStaffBasicinformation = oClass1DBL.GetData(null ,null ,null);

            return PartialView(XStaffBasicinformation);

        }  
        public PartialViewResult Input()
        {
   
            return PartialView();

        }
      
    }
}