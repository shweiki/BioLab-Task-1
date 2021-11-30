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
    public class DBL_HRDepartment
    {
        #region Test 2
        public List<POCO.Department> GetData()
        {
            DAL_HRDepartment oclass1DAL = new DAL_HRDepartment();
            DataSet DS = oclass1DAL.Get();

            //link 

           List<POCO.Department> LAttribute = new List<POCO.Department>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add (new POCO.Department(
                      0,//  (!(currentRow["RC"] is DBNull)) ? Convert.ToInt32(currentRow["RC"]) : 0,
                        (!(currentRow["companyID"] is DBNull)) ? Convert.ToInt32(currentRow["companyID"]) : 0,
                        (!(currentRow["id"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                        currentRow["departmentname"].ToString(),
                        currentRow["notess"].ToString(),
                        (!(currentRow["disable"] is DBNull)) ? Convert.ToInt32(currentRow["disable"]) : 0
                          ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
