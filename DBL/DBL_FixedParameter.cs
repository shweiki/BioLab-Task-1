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
    public class Class1DBL
    {
        #region Test 1 
        public List<POCO.fixedParameter> GetData()
        {
            DAL_FixedParameter oclass1DAL = new DAL_FixedParameter();
            DataSet DS = oclass1DAL.Get();

            //link 

            List<POCO.fixedParameter> LAttribute = new List<POCO.fixedParameter>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add(new POCO.fixedParameter(
                            (!(currentRow["id"] is DBNull)) ? Convert.ToInt32(currentRow["id"]) : 0,
                            (!(currentRow["Hourovertime"] is DBNull)) ? Convert.ToDecimal(currentRow["Hourovertime"]) : 0,
                            (!(currentRow["highestsalary"] is DBNull)) ? Convert.ToDecimal(currentRow["highestsalary"]) : 0,
                            (!(currentRow["expmarroed"] is DBNull)) ? Convert.ToDecimal(currentRow["expmarroed"]) : 0,
                            (!(currentRow["socialper"] is DBNull)) ? Convert.ToDecimal(currentRow["socialper"]) : 0,
                            (!(currentRow["expsingle"] is DBNull)) ? Convert.ToDecimal(currentRow["expsingle"]) : 0
                          ));
                    }
                }
            }
            return LAttribute;

        }

        #endregion
        public bool SetData(POCO.fixedParameter FP)
        {
            DAL_FixedParameter oclass1DAL = new DAL_FixedParameter();
            DataSet DS = oclass1DAL.Set(FP.id,FP.Hourovertime,FP.highestsalary,FP.expmarroed,FP.socialper,FP.expsingle);

            //link 

            bool res = false;

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    res = true;
                        
                }
            }
            return res;

        }


    }
}
