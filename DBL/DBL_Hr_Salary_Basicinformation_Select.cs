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
    public class DBL_Hr_Salary_Basicinformation_Select
    {
        #region Test 2
        public List<POCO.SalaryBasicInformation> GetData(int? empno, int? empno2,string empname,int? branchno,int? departmentno)
        {
            DAL_Hr_Salary_Basicinformation_Select oclass1DAL = new DAL_Hr_Salary_Basicinformation_Select();
            DataSet DS = oclass1DAL.Get(empno,  empno2,  empname,  branchno,  departmentno);

            //link 

           List<POCO.SalaryBasicInformation> LAttribute = new List<POCO.SalaryBasicInformation>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add (new POCO.SalaryBasicInformation(
                        (!(currentRow["empno"] is DBNull)) ? Convert.ToInt32(currentRow["empno"]) : 0,
                        currentRow["FullAnname"].ToString(),
                            (!(currentRow["saljd"] is DBNull)) ? Convert.ToDecimal(currentRow["saljd"]) : 0,
                            (!(currentRow["socialj"] is DBNull)) ? Convert.ToDecimal(currentRow["socialj"]) : 0,
                            (!(currentRow["tax_pass_value"] is DBNull)) ? Convert.ToDecimal(currentRow["tax_pass_value"]) : 0,
                            (!(currentRow["emptax"] is DBNull)) ? Convert.ToDecimal(currentRow["emptax"]) : 0,
                            (!(currentRow["wifetax"] is DBNull)) ? Convert.ToDecimal(currentRow["wifetax"]) : 0,
                        (!(currentRow["month_count"] is DBNull)) ? Convert.ToInt32(currentRow["month_count"]) : 0
                          ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
