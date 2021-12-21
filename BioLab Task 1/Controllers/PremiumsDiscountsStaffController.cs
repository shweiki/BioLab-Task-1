using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class PremiumsDiscountsStaffController : Controller
    {
        public ActionResult Index()
        {
            DBL_PremiumsDiscountsStaffGet oClass1DBL = new DBL_PremiumsDiscountsStaffGet();
            List<POCO.PremiumsDiscountsStaff> XPremiumsDiscountsStaffInformation = oClass1DBL.GetData(null,DateTime.Today, DateTime.Today, null,null,null,null,null,null);
            return View(XPremiumsDiscountsStaffInformation);
        }
        
        [HttpPost]
        public ActionResult PremiumsDiscountsStaffSearch(int? SelcetBonusesOpponent, DateTime? FromDate, DateTime? ToDate, String Option , int? FromEmpNo, int? ToEmpNo, string EmpName, int? SelectBranch, int? SelcetDepartment)
        {

            DBL_PremiumsDiscountsStaffGet oClass1DBL = new DBL_PremiumsDiscountsStaffGet();
            List<POCO.PremiumsDiscountsStaff> XPremiumsDiscountsStaffInformation = oClass1DBL.GetData(SelcetBonusesOpponent, FromDate , ToDate, Option, FromEmpNo, ToEmpNo, EmpName, SelectBranch, SelcetDepartment);

            return PartialView("PremiumsDiscountsStaffSearch", XPremiumsDiscountsStaffInformation);
        }


    }
}