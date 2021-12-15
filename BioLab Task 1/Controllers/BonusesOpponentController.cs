using DBL;
using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioLab_Task_1.Controllers
{
    public class BonusesOpponentController : Controller
    {
        public PartialViewResult Select()
        {
            DBL_BonusesOpponent oClass1DBL = new DBL_BonusesOpponent();
            List<POCO.BonusesOpponent> XBonusesOpponent = oClass1DBL.GetData();
            return PartialView(XBonusesOpponent);

        }
      
    }
}