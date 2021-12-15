using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
namespace DBL
{
    public class DBL_PremiumsDiscountsStaffGet
    {
        #region Test 2
        public List<POCO.PremiumsDiscountsStaff> GetData(int? PD, DateTime fromdate, DateTime todate, String option, int? empno, int? empno2, string empname, int? branchno, int? departmentno)
        {
            DAL_PremiumsDiscountStaff_P oclass1DAL = new DAL_PremiumsDiscountStaff_P();
            DataSet DS = oclass1DAL.Get(PD , fromdate , todate , option,empno,  empno2,  empname,  branchno,  departmentno);

            //link 

           List<POCO.PremiumsDiscountsStaff> LAttribute = new List<POCO.PremiumsDiscountsStaff>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add (new POCO.PremiumsDiscountsStaff(
                        (!(currentRow["empno"] is DBNull)) ? Convert.ToInt32(currentRow["empno"]) : 0,
                        currentRow["FullAnname"].ToString(),
                        currentRow["desc"].ToString(),
                             Convert.ToDateTime(currentRow["fromdate"]) ,
                            Convert.ToDateTime(currentRow["todate"]) ,
                          Convert.ToDecimal(currentRow["value"]) 
                          
                          ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
