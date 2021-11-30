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
    public class DBL_LocationBranch
    {
        #region Test 2
        public List<POCO.LocationBranch> GetData()
        {
            DAL_LocationBranch oclass1DAL = new DAL_LocationBranch();
            DataSet DS = oclass1DAL.Get();

            //link 

           List<POCO.LocationBranch> LAttribute = new List<POCO.LocationBranch>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add (new POCO.LocationBranch(
                        (!(currentRow["id"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                        currentRow["Name"].ToString(),
                        currentRow["Phone"].ToString(),
                        currentRow["Fax"].ToString(),
                        currentRow["Country"].ToString(),
                        currentRow["City"].ToString(),
                        currentRow["Address"].ToString(),
                        currentRow["note"].ToString(),
                        (!(currentRow["MangerId"] is DBNull)) ? Convert.ToInt32(currentRow["MangerId"]) : 0,
                        (!(currentRow["SupervisorId1"] is DBNull)) ? Convert.ToInt32(currentRow["SupervisorId1"]) : 0,
                        (!(currentRow["SupervisorId2"] is DBNull)) ? Convert.ToInt32(currentRow["SupervisorId2"]) : 0,
                        (!(currentRow["Disable"] is DBNull)) ? Convert.ToInt32(currentRow["Disable"]) : 0
                          ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
