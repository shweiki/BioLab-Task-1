using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class LocationBranchController : Controller
    {
        public PartialViewResult Select()
        {
            DBL_LocationBranch oClass1DBL = new DBL_LocationBranch();
            List<POCO.LocationBranch> XLocation = oClass1DBL.GetData();
            return PartialView(XLocation);
        }
      
    }
}