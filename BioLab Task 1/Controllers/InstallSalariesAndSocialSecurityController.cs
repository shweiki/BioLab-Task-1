using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class InstallSalariesAndSocialSecurityController : Controller
    {
        public ActionResult Index()
        {
            DBL_Hr_Salary_Basicinformation_Select oClass1DBL = new DBL_Hr_Salary_Basicinformation_Select();
            List<POCO.SalaryBasicInformation> XSalaryBasicInformation = oClass1DBL.GetData(null,null,null,null,null);
            return View(XSalaryBasicInformation);
        }
        
        [HttpPost]
        public ActionResult SalariesAndSocialSecuritySearch(int? FromEmpNo, int? ToEmpNo, string SelectEmpName, int? SelectBranch, int? SelcetDepartment)
        {

            DBL_Hr_Salary_Basicinformation_Select oClass1DBL = new DBL_Hr_Salary_Basicinformation_Select();
            List<POCO.SalaryBasicInformation> XSalaryBasicInformation = oClass1DBL.GetData(FromEmpNo, ToEmpNo, SelectEmpName, SelectBranch, SelcetDepartment);
            return View("Index", XSalaryBasicInformation);
            //return PartialView("SalaryTable", XSalaryBasicInformation);
        }


    }
}