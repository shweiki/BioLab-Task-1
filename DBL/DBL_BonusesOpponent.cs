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
    public class DBL_BonusesOpponent
    {
        #region Test 2
        public List<POCO.BonusesOpponent> GetData()
        {
            DAL_BonusesOpponent oclass1DAL = new DAL_BonusesOpponent();
            DataSet DS = oclass1DAL.Get();

            //link 

           List<POCO.BonusesOpponent> LAttribute = new List<POCO.BonusesOpponent>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add (new POCO.BonusesOpponent(
                        (!(currentRow["id"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                        currentRow["descc"].ToString(),
                        (!(currentRow["flag"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                        (!(currentRow["social"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                        (!(currentRow["tax"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                        currentRow["notes"].ToString()
                        ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
