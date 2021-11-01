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
        public List<POCO.Attendance> selectData()
        {
            Class1DAL oclass1DAL = new Class1DAL();
            DataSet DS = oclass1DAL.selectData1(0,0,"","","");

            //link 

            List<POCO.Attendance> LAttribute = new List<POCO.Attendance>();

            if (DS != null)
            {
                if (DS.Tables.Count > 0)
                {
                    DataRow currentRow = null;
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        currentRow = DS.Tables[0].Rows[i];
                        LAttribute.Add(new POCO.Attendance(
                            (!(currentRow["id_auto"] is DBNull)) ? Convert.ToInt32(currentRow["id_auto"]) : 0,
                            (!(currentRow["idout"] is DBNull)) ? Convert.ToInt32(currentRow["idout"]) : 0,
                            (!(currentRow["USERID"] is DBNull)) ? Convert.ToInt32(currentRow["USERID"]) : 0,
                            currentRow["empname"].ToString(),
                            currentRow["days"].ToString(),
                            (!(currentRow["checkdate"] is DBNull)) ? Convert.ToDateTime(currentRow["checkdate"]) : DateTime.Now,
                            currentRow["checkin"].ToString(),
                            currentRow["checkout"].ToString(),
                            currentRow["shift"].ToString(),
                            currentRow["diffIn"].ToString(),
                            currentRow["diffOut"].ToString()));
                    }
                }
            }
            return LAttribute;

        }

        #endregion


    }
}
