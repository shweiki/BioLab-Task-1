using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LocationBranch : Database
    {
        #region "DAL_LocationBranch"
        public DataSet Get()
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
              //cmd.Parameters.AddWithValue("@id", 0);
              //cmd.Parameters.AddWithValue("@Name", "");
           
                cmd.Connection = new SqlConnection(GotoDBKey("SCon"));
                cmd.CommandText = "HR_LocationBranch_Select";
                return ExecuteDataSet(cmd);
            }
        }
      #endregion
    }
}
