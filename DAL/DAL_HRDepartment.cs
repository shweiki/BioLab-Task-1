using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HRDepartment : Database
    {
        #region "DAL_HRDepartment"
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
                cmd.CommandText = "HR_Department_select";
                return ExecuteDataSet(cmd);
            }
        }
      #endregion
    }
}
