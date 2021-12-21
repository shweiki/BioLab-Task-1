using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BonusesOpponent : Database
    {
        #region "DAL_BonusesOpponent"
        public DataSet Get()
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
               /* cmd.Parameters.AddWithValue("@companyID",null);
                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@departmentname", null);
                cmd.Parameters.AddWithValue("@notess", null);
                cmd.Parameters.AddWithValue("@disable", null);*/

                cmd.Connection = new SqlConnection(GotoDBKey("SCon"));
                cmd.CommandText = "SD_Premiums_discounts";
                return ExecuteDataSet(cmd);
            }
        }
      #endregion
    }
}
